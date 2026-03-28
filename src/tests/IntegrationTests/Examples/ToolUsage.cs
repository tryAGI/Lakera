/*
order: 30
title: AIFunction Tools
slug: aifunction-tools

Use Lakera Guard as an AIFunction tool with any IChatClient agent.
*/

namespace Lakera.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ToolUsage()
    {
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools for use with any IChatClient.
        var guardTool = client.AsGuardTool();
        var guardResultsTool = client.AsGuardResultsTool();

        //// The tools can be added to ChatOptions.Tools for any MEAI-compatible chat client.
        guardTool.Name.Should().Be("GuardContent");
        guardResultsTool.Name.Should().Be("GuardContentDetailed");
    }
}
