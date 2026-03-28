# CLAUDE.md -- Lakera SDK

## Overview

Auto-generated C# SDK for [Lakera Guard](https://www.lakera.ai/) -- AI security platform for detecting prompt injection, jailbreaks, PII leakage, profanity, malicious links, and other threats in LLM applications.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Lakera Guard API documentation.

## Build & Test

```bash
dotnet build Lakera.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new LakeraClient(apiKey); // LAKERA_API_KEY env var
```

## Key Files

- `src/libs/Lakera/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Lakera)
- `src/libs/Lakera/generate.sh` -- Runs autosdk on local spec (no download step)
- `src/libs/Lakera/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Lakera/Extensions/LakeraClient.Tools.cs` -- MEAI AIFunction tools (AsGuardTool, AsGuardResultsTool)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/v2/guard` | POST | Screen content for prompt injection, jailbreaks, PII, profanity, malicious links |
| `/v2/guard/results` | POST | Get detailed detection results with confidence scores and matched text spans |

## MEAI Integration

The SDK provides `AIFunction` tools for use with any `IChatClient`:

```csharp
var lakera = new LakeraClient(apiKey);

// Create tools
var guardTool = lakera.AsGuardTool();       // Screen content for threats
var detailsTool = lakera.AsGuardResultsTool(); // Detailed results with confidence scores

// Use with any IChatClient
var options = new ChatOptions
{
    Tools = [guardTool, detailsTool],
};
```

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Lakera Guard docs
- 2 endpoints: `/v2/guard` (screening) and `/v2/guard/results` (detailed results)
- Auth: Standard `http/bearer` scheme (API key from platform.lakera.ai)
- Base URL: `https://api.lakera.ai`
- Messages follow OpenAI chat format (role + content)
- Policy parameter allows inline detector configuration (thresholds, enabled/disabled)
