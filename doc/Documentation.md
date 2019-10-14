## Documentation

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
