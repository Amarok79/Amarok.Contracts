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

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;


namespace Amarok.Contracts
{
    internal partial class Verify
    {
        /// <summary>
        ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsInRange(Int32 value, Int32 lowerLimit, Int32 upperLimit, String paramName)
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
        ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsInRange(Int64 value, Int64 lowerLimit, Int64 upperLimit, String paramName)
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
        ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsInRange(Double value, Double lowerLimit, Double upperLimit, String paramName)
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
        ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
        ///     upper limit.
        /// </summary>
        /// 
        /// <param name="value">
        ///     The value to verify.
        /// </param>
        /// <param name="lowerLimit">
        ///     The inclusive lower limit.
        /// </param>
        /// <param name="upperLimit">
        ///     The inclusive upper limit.
        /// </param>
        /// <param name="paramName">
        ///     The name of the method parameter that is verified.
        /// </param>
        /// 
        /// <exception cref="ArgumentExceedsLowerLimitException">
        ///     Values exceeding the inclusive lower limit are invalid.
        /// </exception>
        /// <exception cref="ArgumentExceedsUpperLimitException">
        ///     Values exceeding the inclusive upper limit are invalid.
        /// </exception>
        [DebuggerStepThrough]
        public static void IsInRange(TimeSpan value, TimeSpan lowerLimit, TimeSpan upperLimit, String paramName)
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
            ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
            ///     upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="lowerLimit">
            ///     The inclusive lower limit.
            /// </param>
            /// <param name="upperLimit">
            ///     The inclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsLowerLimitException">
            ///     Values exceeding the inclusive lower limit are invalid.
            /// </exception>
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the inclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsInRange(Int32 value, Int32 lowerLimit, Int32 upperLimit, String paramName)
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
            ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
            ///     upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="lowerLimit">
            ///     The inclusive lower limit.
            /// </param>
            /// <param name="upperLimit">
            ///     The inclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsLowerLimitException">
            ///     Values exceeding the inclusive lower limit are invalid.
            /// </exception>
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the inclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsInRange(Int64 value, Int64 lowerLimit, Int64 upperLimit, String paramName)
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
            ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
            ///     upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="lowerLimit">
            ///     The inclusive lower limit.
            /// </param>
            /// <param name="upperLimit">
            ///     The inclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsLowerLimitException">
            ///     Values exceeding the inclusive lower limit are invalid.
            /// </exception>
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the inclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsInRange(Double value, Double lowerLimit, Double upperLimit, String paramName)
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
            ///     Verifies that the given value is equal to or greater than the given lower limit and equal to or less than the given
            ///     upper limit.
            /// </summary>
            /// 
            /// <param name="value">
            ///     The value to verify.
            /// </param>
            /// <param name="lowerLimit">
            ///     The inclusive lower limit.
            /// </param>
            /// <param name="upperLimit">
            ///     The inclusive upper limit.
            /// </param>
            /// <param name="paramName">
            ///     The name of the method parameter that is verified.
            /// </param>
            /// 
            /// <exception cref="ArgumentExceedsLowerLimitException">
            ///     Values exceeding the inclusive lower limit are invalid.
            /// </exception>
            /// <exception cref="ArgumentExceedsUpperLimitException">
            ///     Values exceeding the inclusive upper limit are invalid.
            /// </exception>
            [Conditional("DEBUG"), DebuggerStepThrough]
            public static void IsInRange(TimeSpan value, TimeSpan lowerLimit, TimeSpan upperLimit, String paramName)
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
}
