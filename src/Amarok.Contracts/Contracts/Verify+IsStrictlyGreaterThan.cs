// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyGreaterThan(Int32 value, Int32 lowerLimit, String paramName)
    {
        if (value <= lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsStrictlyGreaterThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyGreaterThan(Int64 value, Int64 lowerLimit, String paramName)
    {
        if (value <= lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsStrictlyGreaterThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyGreaterThan(Double value, Double lowerLimit, String paramName)
    {
        if (value <= lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsStrictlyGreaterThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyGreaterThan(TimeSpan value, TimeSpan lowerLimit, String paramName)
    {
        if (value <= lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsStrictlyGreaterThan
            );
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyGreaterThan(Int32 value, Int32 lowerLimit, String paramName)
        {
            if (value <= lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsStrictlyGreaterThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyGreaterThan(Int64 value, Int64 lowerLimit, String paramName)
        {
            if (value <= lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsStrictlyGreaterThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyGreaterThan(Double value, Double lowerLimit, String paramName)
        {
            if (value <= lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsStrictlyGreaterThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyGreaterThan(TimeSpan value, TimeSpan lowerLimit, String paramName)
        {
            if (value <= lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsStrictlyGreaterThan
                );
            }
        }
    }
}
