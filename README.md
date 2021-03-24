# Akv Demo

## Create project

```
dotnet new sln 
dotnet new console --name AkvDemo
dotnet new xunit --name AkvDemoTest
dotnet sln add AkvDemoTest
dotnet sln add AkvDemo
cd AkvDemoTest
dotnet add reference ../AkvDemo
```

```
dotnet add package Azure.Security.KeyVault.Secrets
dotnet add package Azure.Identity
dotnet test
dotnet test --filter UnitTest1.TestSecret
```