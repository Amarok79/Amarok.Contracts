![CI](https://github.com/Amarok79/Amarok.Contracts/workflows/CI/badge.svg)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2FAmarok79%2FAmarok.Contracts%2Fmaster)](https://dashboard.stryker-mutator.io/reports/github.com/Amarok79/Amarok.Contracts/master)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Amarok79_Amarok.Contracts&metric=alert_status)](https://sonarcloud.io/dashboard?id=Amarok79_Amarok.Contracts)
[![NuGet](https://img.shields.io/nuget/v/Amarok.Contracts.svg?logo=)](https://www.nuget.org/packages/Amarok.Contracts/)

# Introduction

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


# Redistribution

The library is redistributed as source-only NuGet package: [Amarok.Contracts](https://www.nuget.org/packages/Amarok.Contracts/). The package targets .NET Standard 2.0 and .NET 5.0.

Tests are performed on .NET Framework 4.8, .NET Core 2.1, .NET Core 3.1 and .NET 5.0.


# Documentation

It's common practice to verify argument values on public types. This generally consists of a condition and a throw statement.

```cs
public void SomeMethod(String text)
{
  if (text == null)
    throw new ArgumentNullException(nameof(text));
  if (String.IsNullOrEmpty(text))
    throw new ArgumentException(nameof(text));

  // the method's logic expects a non-null and non-empty string
}
```

This can become a bit tedious when you have a large public surface.

Using this library's static type **Verify** we can simply this as following.

```cs
public void SomeMethod(String text)
{
  Verify.NotNull(text, nameof(text));

  // the method's logic expects a non-null and non-empty string
}
```

## Supported Methods

| Method on Verify            | Operates on Types               | Potentially throws                  |
| ---                         | ---                             | ---                                 |
| NotNull(..)                 | Object                          | ArgumentNullException               |
| NotEmpty(..)                | String, IEnumerable<T>          | ArgumentNullException, ArgumentException |
| NotEmptyOrWhiteSpace(..)    | String                          | ArgumentNullException, ArgumentException |
| IsPositive(..)              | Int32, Int64, Double, TimeSpan  | ArgumentOutOfRangeException         |
| IsStrictlyPositive(..)      | Int32, Int64, Double, TimeSpan  | ArgumentOutOfRangeException         |
| IsLessThan(..)              | Int32, Int64, Double, TimeSpan  | ArgumentExceedsUpperLimitException  |
| IsStrictlyLessThan(..)      | Int32, Int64, Double, TimeSpan  | ArgumentExceedsUpperLimitException  |
| IsGreaterThan(..)           | Int32, Int64, Double, TimeSpan  | ArgumentExceedsLowerLimitException  |
| IsStrictlyGreaterThan(..)   | Int32, Int64, Double, TimeSpan  | ArgumentExceedsLowerLimitException  |
| IsInRange(..)               | Int32, Int64, Double, TimeSpan  | ArgumentExceedsLowerLimitException, ArgumentExceedsUpperLimitException |
| IsStrictlyInRange(..)       | Int32, Int64, Double, TimeSpan  | ArgumentExceedsLowerLimitException, ArgumentExceedsUpperLimitException |
| IsSubclassOf(..)            | Type                            | ArgumentNullException, ArgumentException |
| IsAssignableTo(..)          | Type                            | ArgumentNullException, ArgumentException |
| ArraySegment(..)            | T[]                             | ArgumentNullException, ArgumentOutOfRangeException, ArgumentExceedsUpperLimitException |
