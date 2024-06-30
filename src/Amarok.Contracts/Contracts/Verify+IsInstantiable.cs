// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given type is not null and that it represents an instantiable type.
    /// </summary>
    /// 
    /// <param name="type">
    ///     The type to verify.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentNullException">
    ///     Null values are invalid.
    /// </exception>
    /// <exception cref="ArgumentNullException">
    ///     Types representing interface or abstract base classes are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void IsInstantiable(Type? type, String paramName)
    {
        if (type is null)
        {
            throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
        }

        if (type.IsInterface || type.IsAbstract || type.IsGenericTypeDefinition)
        {
            throw new ArgumentException(ExceptionResources.ArgumentIsInstantiable, paramName);
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given type is not null and that it represents an instantiable type.
        /// </summary>
        /// 
        /// <param name="type">
        ///     The type to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentNullException">
        ///     Null values are invalid.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        ///     Types representing interface or abstract base classes are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void IsInstantiable(Type? type, String paramName)
        {
            if (type is null)
            {
                throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
            }

            if (type.IsInterface || type.IsAbstract || type.IsGenericTypeDefinition)
            {
                throw new ArgumentException(ExceptionResources.ArgumentIsInstantiable, paramName);
            }
        }
    }
}
