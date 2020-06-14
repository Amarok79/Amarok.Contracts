[![Build Status](https://dev.azure.com/amarok79/Amarok/_apis/build/status/Amarok.Contracts?branchName=master)](https://dev.azure.com/amarok79/Amarok/_build/latest?definitionId=19&branchName=master)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Amarok79_Contracts&metric=alert_status)](https://sonarcloud.io/dashboard?id=Amarok79_Contracts)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=Amarok79_Contracts&metric=coverage)](https://sonarcloud.io/dashboard?id=Amarok79_Contracts)
[![NuGet](https://img.shields.io/nuget/v/Amarok.Contracts.svg?logo=)](https://www.nuget.org/packages/Amarok.Contracts/)

## Introduction

This library provides static helper methods for verifying argument values, for example, to verify that string arguments are neither null nor empty, or that numeric arguments are within a defined value range.

```cs
public void SomeMethod(String text, Int32 value)
{
  Verify.NotNull(text, nameof(text));
  Verify.IsStrictlyPositive(value, nameof(value));
  
  ...
}
```

If those contracts are violated, appropriate argument exceptions are thrown.


## Redistribution

The library is redistributed as source-only NuGet package: [Amarok.Contracts](https://www.nuget.org/packages/Amarok.Contracts/)


## Further Links

For documentation about how to use this library, refer to [Documentation](doc/Documentation.md).
