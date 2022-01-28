// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is equal to or less than the given upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="upperLimit">
    ///     The inclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the inclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsLessThan(Int32 value, Int32 upperLimit, String paramName)
    {
        if (value > upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsLessThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or less than the given upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="upperLimit">
    ///     The inclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the inclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsLessThan(Int64 value, Int64 upperLimit, String paramName)
    {
        if (value > upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsLessThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or less than the given upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="upperLimit">
    ///     The inclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the inclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsLessThan(Double value, Double upperLimit, String paramName)
    {
        if (value > upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsLessThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or less than the given upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="upperLimit">
    ///     The inclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the inclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
    {
        if (value > upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsLessThan
            );
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is equal to or less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsLessThan(Int32 value, Int32 upperLimit, String paramName)
        {
            if (value > upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsLessThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsLessThan(Int64 value, Int64 upperLimit, String paramName)
        {
            if (value > upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsLessThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsLessThan(Double value, Double upperLimit, String paramName)
        {
            if (value > upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsLessThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
        {
            if (value > upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsLessThan
                );
            }
        }
    }
}
