/*
order: 10
title: Guard Content
slug: guard-content

Screen content for prompt injection, jailbreaks, PII, and other threats.
*/

namespace Lakera.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GuardContent()
    {
        using var client = GetAuthenticatedClient();

        //// Screen a user message for threats using the Guard endpoint.
        var response = await client.GuardAsync(
            messages:
            [
                new GuardMessage
                {
                    Role = GuardMessageRole.User,
                    Content = "Hello, how are you?",
                },
            ]);

        //// The response indicates whether the content was flagged.
        response.Flagged.Should().BeFalse();
    }
}
