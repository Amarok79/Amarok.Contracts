// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is equal to or greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The inclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the inclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsGreaterThan(Int32 value, Int32 lowerLimit, String paramName)
    {
        if (value < lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsGreaterThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The inclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the inclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsGreaterThan(Int64 value, Int64 lowerLimit, String paramName)
    {
        if (value < lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsGreaterThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The inclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the inclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsGreaterThan(Double value, Double lowerLimit, String paramName)
    {
        if (value < lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsGreaterThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or greater than the given lower limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The inclusive lower limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the inclusive lower limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsGreaterThan(TimeSpan value, TimeSpan lowerLimit, String paramName)
    {
        if (value < lowerLimit)
        {
            throw new ArgumentExceedsLowerLimitException(
                paramName,
                value,
                lowerLimit,
                ExceptionResources.ArgumentIsGreaterThan
            );
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is equal to or greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsGreaterThan(Int32 value, Int32 lowerLimit, String paramName)
        {
            if (value < lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsGreaterThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsGreaterThan(Int64 value, Int64 lowerLimit, String paramName)
        {
            if (value < lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsGreaterThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsGreaterThan(Double value, Double lowerLimit, String paramName)
        {
            if (value < lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsGreaterThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or greater than the given lower limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsGreaterThan(TimeSpan value, TimeSpan lowerLimit, String paramName)
        {
            if (value < lowerLimit)
            {
                throw new ArgumentExceedsLowerLimitException(
                    paramName,
                    value,
                    lowerLimit,
                    ExceptionResources.ArgumentIsGreaterThan
                );
            }
        }
    }
}
