namespace Lakera.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LakeraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LAKERA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LAKERA_API_KEY environment variable is not found.");

        var client = new LakeraClient(apiKey);
        
        return client;
    }
}
