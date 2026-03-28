/*
order: 20
title: Detailed Results
slug: detailed-results

Get detailed detection results with confidence scores and matched text spans.
*/

namespace Lakera.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GuardResults()
    {
        using var client = GetAuthenticatedClient();

        //// Get detailed screening results with confidence scores.
        var response = await client.GuardResultsAsync(
            messages:
            [
                new GuardMessage
                {
                    Role = GuardMessageRole.User,
                    Content = "My email is john@example.com and my phone is 555-0123.",
                },
            ]);

        //// The detailed response includes per-detector results.
        response.Flagged.Should().BeTrue();
    }
}
