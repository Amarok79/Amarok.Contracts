/* MIT License
 * 
 * Copyright (c) 2020, Olaf Kober
 * https://github.com/Amarok79/Amarok.Contracts
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts
{
    internal partial class Verify
    {
        /// <summary>
        ///     Verifies that the given value is less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyLessThan(Int32 value, Int32 upperLimit, String paramName)
        {
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
        ///     Verifies that the given value is less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyLessThan(Int64 value, Int64 upperLimit, String paramName)
        {
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
        ///     Verifies that the given value is less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyLessThan(Double value, Double upperLimit, String paramName)
        {
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
        ///     Verifies that the given value is less than the given upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="upperLimit">
        ///     The exclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the exclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsStrictlyLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
        {
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
            ///     Verifies that the given value is less than the given upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="upperLimit">
            ///     The exclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the exclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyLessThan(Int32 value, Int32 upperLimit, String paramName)
            {
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
            ///     Verifies that the given value is less than the given upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="upperLimit">
            ///     The exclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the exclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyLessThan(Int64 value, Int64 upperLimit, String paramName)
            {
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
            ///     Verifies that the given value is less than the given upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="upperLimit">
            ///     The exclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the exclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyLessThan(Double value, Double upperLimit, String paramName)
            {
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
            ///     Verifies that the given value is less than the given upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="upperLimit">
            ///     The exclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the exclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsStrictlyLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
            {
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
}
