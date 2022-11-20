// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit and less than the given
    ///     upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="upperLimit">
    ///     The exclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the exclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyInRange(Int32 value, Int32 lowerLimit, Int32 upperLimit, String paramName)
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

        if (value >= upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsStrictlyLessThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit and less than the given
    ///     upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="upperLimit">
    ///     The exclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the exclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyInRange(Int64 value, Int64 lowerLimit, Int64 upperLimit, String paramName)
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

        if (value >= upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsStrictlyLessThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit and less than the given
    ///     upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="upperLimit">
    ///     The exclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the exclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyInRange(Double value, Double lowerLimit, Double upperLimit, String paramName)
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

        if (value >= upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsStrictlyLessThan
            );
        }
    }

    /// <summary>
    ///     Verifies that the given value is greater than the given lower limit and less than the given
    ///     upper limit.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="lowerLimit">
    ///     The exclusive lower limit.
    /// </param>
    /// <param name="upperLimit">
    ///     The exclusive upper limit.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentExceedsLowerLimitException">
    ///     Values exceeding the exclusive lower limit are invalid.
    /// </exception>
    /// <exception cref="ArgumentExceedsUpperLimitException">
    ///     Values exceeding the exclusive upper limit are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsStrictlyInRange(TimeSpan value, TimeSpan lowerLimit, TimeSpan upperLimit, String paramName)
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

        if (value >= upperLimit)
        {
            throw new ArgumentExceedsUpperLimitException(
                paramName,
                value,
                upperLimit,
                ExceptionResources.ArgumentIsStrictlyLessThan
            );
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit and less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyInRange(Int32 value, Int32 lowerLimit, Int32 upperLimit, String paramName)
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

            if (value >= upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsStrictlyLessThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit and less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyInRange(Int64 value, Int64 lowerLimit, Int64 upperLimit, String paramName)
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

            if (value >= upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsStrictlyLessThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit and less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyInRange(Double value, Double lowerLimit, Double upperLimit, String paramName)
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

            if (value >= upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsStrictlyLessThan
                );
            }
        }

        /// <summary>
        ///     Verifies that the given value is greater than the given lower limit and less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The exclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the exclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsStrictlyInRange(TimeSpan value, TimeSpan lowerLimit, TimeSpan upperLimit, String paramName)
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

            if (value >= upperLimit)
            {
                throw new ArgumentExceedsUpperLimitException(
                    paramName,
                    value,
                    upperLimit,
                    ExceptionResources.ArgumentIsStrictlyLessThan
                );
            }
        }
    }
}
