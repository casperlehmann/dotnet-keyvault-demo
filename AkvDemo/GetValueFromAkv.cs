using System;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace AkvDemo
{
    public class Akv
    {
        public static string AzureTenantId;
        public static string AzureClientId;
        public static string AzureClientSecret;
        public static string keyVaultName;
        static Akv()
        {
            AzureClientId = Environment.GetEnvironmentVariable("AZURE_CLIENT_ID");
            AzureClientSecret = Environment.GetEnvironmentVariable("AZURE_CLIENT_SECRET");
            AzureTenantId = Environment.GetEnvironmentVariable("AZURE_TENANT_ID");
            keyVaultName = Environment.GetEnvironmentVariable("KEY_VAULT_NAME");
        }

        public string GetValue(string valueName)
        {
            var kvUri = "https://" + keyVaultName + ".vault.azure.net";
            var tokenCredential = new ClientSecretCredential(AzureTenantId, AzureClientId, AzureClientSecret); //applicationToken
            var client = new SecretClient(new Uri(kvUri), tokenCredential);
            string Value = client.GetSecret(valueName).Value.Value;
            return Value;
        }
    }
}
