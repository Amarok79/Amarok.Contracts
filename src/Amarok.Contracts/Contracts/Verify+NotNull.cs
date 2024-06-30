// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is not a null reference, hence, that it refers to a valid object.
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
    [DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotNull(Object? value, String paramName)
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is not a null reference, hence, that it refers to a valid object.
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
        [Conditional("DEBUG"), DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotNull(Object? value, String paramName)
        {
            if (value is null)
            {
                throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
            }
        }
    }
}
