﻿// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given type is not null and derived from the specified base class.
    /// </summary>
    /// 
    /// <param name="type">
    ///     The type to verify.
    /// </param>
    /// <param name="baseType">
    ///     The expected base class.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentNullException">
    ///     Null values are invalid.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Types not derived from a specific base class are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsSubclassOf(Type? type, Type baseType, String paramName)
    {
        if (type is null)
            throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);

        if (!type.IsSubclassOf(baseType))
            throw new ArgumentException(ExceptionResources.ArgumentIsSubclassOf, paramName);
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given type is not null and derived from the specified base class.
        /// </summary>
        /// 
        /// <param name="type">
        ///     The type to verify.
        /// </param>
        /// <param name="baseType">
        ///     The expected base class.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentNullException">
        ///     Null values are invalid.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     Types not derived from a specific base class are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsSubclassOf(Type? type, Type baseType, String paramName)
        {
            if (type is null)
                throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);

            if (!type.IsSubclassOf(baseType))
                throw new ArgumentException(ExceptionResources.ArgumentIsSubclassOf, paramName);
        }
    }
}
