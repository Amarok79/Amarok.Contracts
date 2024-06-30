// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is neither null nor an empty or whitespace string.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentNullException">
    ///     Null values are invalid.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Empty strings are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void NotEmptyOrWhiteSpace(String? value, String paramName)
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
        }

        if (String.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException(ExceptionResources.ArgumentEmptyString, paramName);
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is neither null nor an empty or whitespace string.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentNullException">
        ///     Null values are invalid.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     Empty strings are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void NotEmptyOrWhiteSpace(String? value, String paramName)
        {
            if (value is null)
            {
                throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
            }

            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionResources.ArgumentEmptyString, paramName);
            }
        }
    }
}
