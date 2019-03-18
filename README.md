[![Build Status](https://dev.azure.com/amarok79/Amarok/_apis/build/status/Amarok.Contracts)](https://dev.azure.com/amarok79/Amarok/_build/latest?definitionId=9)
[![Build Status](https://sonarcloud.io/api/project_badges/measure?project=Amarok79_Contracts&metric=alert_status)](https://sonarcloud.io/dashboard?id=Amarok79_Contracts)
[![Build Status](https://sonarcloud.io/api/project_badges/measure?project=Amarok79_Contracts&metric=coverage)](https://sonarcloud.io/api/project_badges/measure?project=Amarok79_Contracts&metric=coverage)
[![NuGet](https://img.shields.io/nuget/v/Amarok.Contracts.svg?logo=)](https://www.nuget.org/packages/Amarok.Contracts/)

## Introduction

This library provides static helper methods for verifying argument values, for example, to verify that argument values are neither null nor empty strings, or that argument values are within a defined value range.

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

The library is redistributed as NuGet package: [Amarok.Contracts](https://www.nuget.org/packages/Amarok.Contracts/)

The package provides strong-named binaries for *.NET Standard 2.0* only. Tests are generally performed with *.NET Framework 4.7.1* and *.NET Core 2.1*.


## Further Links

For documentation about how to use this library, refer to [Documentation](doc/Documentation.md).
