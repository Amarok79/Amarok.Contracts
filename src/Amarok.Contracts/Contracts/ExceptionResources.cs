// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

using System;


namespace Amarok.Contracts;


/// <summary>
///     This type serves the infrastructure and is not intended to be used directly.
/// </summary>
internal static class ExceptionResources
{
    /// <summary>
    ///     Looks up a localized string similar to Empty collections are invalid..
    /// </summary>
    internal static String ArgumentEmptyCollection => "Empty collections are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Empty strings are invalid..
    /// </summary>
    internal static String ArgumentEmptyString => "Empty strings are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Types not assignable to a specific type are invalid..
    /// </summary>
    internal static String ArgumentIsAssignableTo => "Types not assignable to a specific type are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Values exceeding the inclusive lower limit are invalid..
    /// </summary>
    internal static String ArgumentIsGreaterThan => "Values exceeding the inclusive lower limit are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Types representing interface or abstract base classes
    ///     are invalid..
    /// </summary>
    internal static String ArgumentIsInstantiable =>
        "Types representing interface or abstract base classes are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Types representing concrete classes or value types are
    ///     invalid..
    /// </summary>
    internal static String ArgumentIsInterface => "Types representing concrete classes or value types are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Values exceeding the inclusive upper limit are invalid..
    /// </summary>
    internal static String ArgumentIsLessThan => "Values exceeding the inclusive upper limit are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Negative values are invalid..
    /// </summary>
    internal static String ArgumentIsPositive => "Negative values are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Values exceeding the exclusive lower limit are invalid..
    /// </summary>
    internal static String ArgumentIsStrictlyGreaterThan => "Values exceeding the exclusive lower limit are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Values exceeding the exclusive upper limit are invalid..
    /// </summary>
    internal static String ArgumentIsStrictlyLessThan => "Values exceeding the exclusive upper limit are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Zero or negative values are invalid..
    /// </summary>
    internal static String ArgumentIsStrictlyPositive => "Zero or negative values are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Types not derived from a specific base class are
    ///     invalid..
    /// </summary>
    internal static String ArgumentIsSubclassOf => "Types not derived from a specific base class are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Null values are invalid..
    /// </summary>
    internal static String ArgumentNull => "Null values are invalid.";

    /// <summary>
    ///     Looks up a localized string similar to Lower limit: .
    /// </summary>
    internal static String LowerLimit => "Lower limit: ";

    /// <summary>
    ///     Looks up a localized string similar to Upper limit: .
    /// </summary>
    internal static String UpperLimit => "Upper limit: ";
}
