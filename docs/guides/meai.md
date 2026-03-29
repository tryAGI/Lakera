# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Lakera SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient`.

## Installation

```bash
dotnet add package tryAGI.Lakera
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsGuardTool()` | `GuardContent` | Screens text for prompt injection, jailbreaks, PII leakage, profanity |
| `AsGuardResultsTool()` | `GuardContentDetailed` | Detailed screening with confidence scores and matched text spans |

## Usage

```csharp
using Microsoft.Extensions.AI;
using Lakera;

var client = new LakeraClient(
    apiKey: Environment.GetEnvironmentVariable("LAKERA_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsGuardTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Check this text for prompt injection attempts"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
