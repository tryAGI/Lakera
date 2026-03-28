#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Globalization;
using Microsoft.Extensions.AI;

namespace Lakera;

/// <summary>
/// Extensions for using LakeraClient as MEAI tools with any IChatClient.
/// </summary>
public static class LakeraToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that screens content for prompt injection,
    /// jailbreaks, PII, profanity, malicious links, and other threats using Lakera Guard.
    /// <para>
    /// This is the primary safety tool — it allows any IChatClient agent to check
    /// user inputs and LLM outputs for security threats in real-time.
    /// </para>
    /// </summary>
    /// <param name="client">The Lakera client to use for screening.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGuardTool(this LakeraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string content, string role, CancellationToken cancellationToken) =>
            {
                var messageRole = ParseRole(role);

                var response = await client.GuardAsync(
                    messages: [new GuardMessage
                    {
                        Role = messageRole,
                        Content = content,
                    }],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatGuardResponse(response);
            },
            name: "GuardContent",
            description: "Screens text content for security threats including prompt injection, jailbreaks, PII leakage, profanity, and malicious links. Returns whether the content is flagged and which threat categories were detected. Use this to validate user inputs or LLM outputs before processing.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that returns detailed detection results
    /// with confidence scores and matched text spans from Lakera Guard.
    /// <para>
    /// Use this when you need granular information about why content was flagged,
    /// including exact text spans and detector confidence values.
    /// </para>
    /// </summary>
    /// <param name="client">The Lakera client to use for screening.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGuardResultsTool(this LakeraClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string content, string role, CancellationToken cancellationToken) =>
            {
                var messageRole = ParseRole(role);

                var response = await client.GuardResultsAsync(
                    messages: [new GuardMessage
                    {
                        Role = messageRole,
                        Content = content,
                    }],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatGuardResultsResponse(response);
            },
            name: "GuardContentDetailed",
            description: "Screens text content for security threats and returns detailed results with confidence scores and matched text spans. Detects prompt injection, jailbreaks, PII, profanity, and malicious links. Use this when you need to understand exactly what was detected and with what confidence.");
    }

    private static GuardMessageRole ParseRole(string role)
    {
        if (string.Equals(role, "system", StringComparison.OrdinalIgnoreCase))
        {
            return GuardMessageRole.System;
        }

        if (string.Equals(role, "assistant", StringComparison.OrdinalIgnoreCase))
        {
            return GuardMessageRole.Assistant;
        }

        return GuardMessageRole.User;
    }

    private static string FormatGuardResponse(GuardResponse response)
    {
        var parts = new List<string>
        {
            $"Flagged: {response.Flagged}",
        };

        if (response.Categories is { } categories)
        {
            var flaggedCategories = new List<string>();
            if (categories.PromptInjection == true) flaggedCategories.Add("prompt_injection");
            if (categories.Jailbreak == true) flaggedCategories.Add("jailbreak");
            if (categories.Pii == true) flaggedCategories.Add("pii");
            if (categories.Profanity == true) flaggedCategories.Add("profanity");
            if (categories.MaliciousLinks == true) flaggedCategories.Add("malicious_links");
            if (categories.UnknownLinks == true) flaggedCategories.Add("unknown_links");
            if (categories.RelevantLanguage == true) flaggedCategories.Add("relevant_language");
            if (categories.ModeratedContent == true) flaggedCategories.Add("moderated_content");

            if (flaggedCategories.Count > 0)
            {
                parts.Add($"Flagged categories: {string.Join(", ", flaggedCategories)}");
            }
            else
            {
                parts.Add("No categories flagged.");
            }
        }

        return string.Join("\n", parts);
    }

    private static string FormatGuardResultsResponse(GuardResultsResponse response)
    {
        var parts = new List<string>
        {
            $"Flagged: {response.Flagged}",
        };

        if (response.Results is { Count: > 0 })
        {
            parts.Add("Detector results:");
            foreach (var result in response.Results)
            {
                var status = result.Flagged == true ? "FLAGGED" : "OK";
                var confidence = result.Confidence?.ToString("F3", CultureInfo.InvariantCulture) ?? "N/A";
                parts.Add($"  - {result.Detector}: {status} (confidence: {confidence})");

                if (result.Matches is { Count: > 0 })
                {
                    foreach (var match in result.Matches)
                    {
                        var matchInfo = $"    Match: \"{match.Text}\"";
                        if (match.EntityType is not null)
                        {
                            matchInfo += $" (type: {match.EntityType})";
                        }
                        if (match.Confidence is not null)
                        {
                            matchInfo += $" (confidence: {match.Confidence.Value.ToString("F3", CultureInfo.InvariantCulture)})";
                        }
                        parts.Add(matchInfo);
                    }
                }
            }
        }

        return string.Join("\n", parts);
    }
}
