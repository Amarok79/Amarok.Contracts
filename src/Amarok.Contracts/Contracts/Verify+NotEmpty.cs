// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;


namespace Amarok.Contracts;


internal partial class Verify
{
    /// <summary>
    ///     Verifies that the given value is neither null nor an empty string.
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
    [DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void NotEmpty(String? value, String paramName)
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
        }

        if (value.Length == 0)
        {
            throw new ArgumentException(ExceptionResources.ArgumentEmptyString, paramName);
        }
    }

    /// <summary>
    ///     Verifies that the given collection is neither null nor empty.
    /// </summary>
    /// 
    /// <param name="collection">
    ///     The collection to verify.
    /// </param>
    /// <param name="paramName">
    ///     The name of the method parameter that is verified.
    /// </param>
    /// 
    /// <exception cref="ArgumentNullException">
    ///     Null values are invalid.
    /// </exception>
    /// <exception cref="ArgumentException">
    ///     Empty collections are invalid.
    /// </exception>
    [DebuggerStepThrough]
    public static void NotEmpty<T>(IEnumerable<T>? collection, String paramName)
    {
        if (collection is null)
        {
            throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
        }

        if (collection is IReadOnlyCollection<T> readOnlyCollection)
        {
            if (readOnlyCollection.Count == 0)
            {
                throw new ArgumentException(ExceptionResources.ArgumentEmptyCollection, paramName);
            }
        }
        else
        {
            if (!collection.Any())
            {
                throw new ArgumentException(ExceptionResources.ArgumentEmptyCollection, paramName);
            }
        }
    }


    [SuppressMessage("ReSharper", "MemberHidesStaticFromOuterClass")]
    internal static partial class Debug
    {
        /// <summary>
        ///     Verifies that the given value is neither null nor an empty string.
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
        [Conditional("DEBUG"), DebuggerStepThrough, MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void NotEmpty(String? value, String paramName)
        {
            if (value is null)
            {
                throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
            }

            if (value.Length == 0)
            {
                throw new ArgumentException(ExceptionResources.ArgumentEmptyString, paramName);
            }
        }

        /// <summary>
        ///     Verifies that the given collection is neither null nor empty.
        /// </summary>
        /// 
        /// <param name="collection">
        ///     The collection to verify.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentNullException">
        ///     Null values are invalid.
        /// </exception>
        /// <exception cref="ArgumentException">
        ///     Empty collections are invalid.
        /// </exception>
        [Conditional("DEBUG"), DebuggerStepThrough]
        public static void NotEmpty<T>(IEnumerable<T>? collection, String paramName)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
            }

            if (collection is IReadOnlyCollection<T> readOnlyCollection)
            {
                if (readOnlyCollection.Count == 0)
                {
                    throw new ArgumentException(ExceptionResources.ArgumentEmptyCollection, paramName);
                }
            }
            else
            {
                if (!collection.Any())
                {
                    throw new ArgumentException(ExceptionResources.ArgumentEmptyCollection, paramName);
                }
            }
        }
    }
}
