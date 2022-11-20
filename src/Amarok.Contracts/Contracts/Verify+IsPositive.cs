// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
    ///     number.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Negative values are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsPositive(Int32 value, String paramName)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
    ///     number.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Negative values are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsPositive(Int64 value, String paramName)
    {
        if (value < 0L)
        {
            throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
    ///     number.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Negative values are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsPositive(Double value, String paramName)
    {
        if (value < 0.0d)
        {
            throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
        }
    }

    /// <summary>
    ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
    ///     number.
    /// </summary>
    /// 
    /// <param name="value">
    ///     The value to verify.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentOutOfRangeException">
    ///     Negative values are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsPositive(TimeSpan value, String paramName)
    {
        if (value.Ticks < 0L)
        {
            throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
        ///     number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Negative values are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsPositive(Int32 value, String paramName)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
        ///     number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Negative values are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsPositive(Int64 value, String paramName)
        {
            if (value < 0L)
            {
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
        ///     number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Negative values are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsPositive(Double value, String paramName)
        {
            if (value < 0.0d)
            {
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
            }
        }

        /// <summary>
        ///     Verifies that the given value is equal to or greater than zero, hence, that it is a positive
        ///     number.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Negative values are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsPositive(TimeSpan value, String paramName)
        {
            if (value.Ticks < 0L)
            {
                throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsPositive);
            }
        }
    }
}
