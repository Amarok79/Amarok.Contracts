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


namespace Amarok.Contracts
{
	internal partial class Verify
	{
		/// <summary>
		/// Verifies that the given array and count represent a valid array segment.
		/// </summary>
		/// 
		/// <param name="array">
		/// The array.</param>
		/// <param name="count">
		/// The count.</param>
		/// 
		/// <exception cref="ArgumentNullException">
		/// Null values are invalid.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Negative values are invalid.</exception>
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the inclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void ArraySegment<T>(T[] array, Int32 count)
		{
			if (array is null)
				throw new ArgumentNullException(nameof(array), ExceptionResources.ArgumentNull);
			if (count < 0)
				throw new ArgumentOutOfRangeException(nameof(count), count, ExceptionResources.ArgumentIsPositive);
			if (count > array.Length)
				throw new ArgumentExceedsUpperLimitException(nameof(count), count, array.Length, ExceptionResources.ArgumentIsLessThan);
		}

		/// <summary>
		/// Verifies that the given array, offset and count represent a valid array segment.
		/// </summary>
		/// 
		/// <param name="array">
		/// The array.</param>
		/// <param name="offset">
		/// The offset.</param>
		/// <param name="count">
		/// The count.</param>
		/// 
		/// <exception cref="ArgumentNullException">
		/// Null values are invalid.</exception>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Negative values are invalid.</exception>
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the inclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void ArraySegment<T>(T[] array, Int32 offset, Int32 count)
		{
			if (array is null)
				throw new ArgumentNullException(nameof(array), ExceptionResources.ArgumentNull);
			if (offset < 0)
				throw new ArgumentOutOfRangeException(nameof(offset), offset, ExceptionResources.ArgumentIsPositive);
			if (count < 0)
				throw new ArgumentOutOfRangeException(nameof(count), count, ExceptionResources.ArgumentIsPositive);
			if ((array.Length > 0 && offset >= array.Length) || (array.Length == 0 && offset > 0))
				throw new ArgumentExceedsUpperLimitException(nameof(offset), offset, array.Length, ExceptionResources.ArgumentIsLessThan);
			if (offset + count > array.Length)
				throw new ArgumentExceedsUpperLimitException(nameof(count), offset + count, array.Length, ExceptionResources.ArgumentIsLessThan);
		}

		internal static partial class Debug
		{
			/// <summary>
			/// Verifies that the given array and count represent a valid array segment.
			/// </summary>
			/// 
			/// <param name="array">
			/// The array.</param>
			/// <param name="count">
			/// The count.</param>
			/// 
			/// <exception cref="ArgumentNullException">
			/// Null values are invalid.</exception>
			/// <exception cref="ArgumentOutOfRangeException">
			/// Negative values are invalid.</exception>
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the inclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void ArraySegment<T>(T[] array, Int32 count)
			{
				if (array is null)
					throw new ArgumentNullException(nameof(array), ExceptionResources.ArgumentNull);
				if (count < 0)
					throw new ArgumentOutOfRangeException(nameof(count), count, ExceptionResources.ArgumentIsPositive);
				if (count > array.Length)
					throw new ArgumentExceedsUpperLimitException(nameof(count), count, array.Length, ExceptionResources.ArgumentIsLessThan);
			}

			/// <summary>
			/// Verifies that the given array, offset and count represent a valid array segment.
			/// </summary>
			/// 
			/// <param name="array">
			/// The array.</param>
			/// <param name="offset">
			/// The offset.</param>
			/// <param name="count">
			/// The count.</param>
			/// 
			/// <exception cref="ArgumentNullException">
			/// Null values are invalid.</exception>
			/// <exception cref="ArgumentOutOfRangeException">
			/// Negative values are invalid.</exception>
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the inclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void ArraySegment<T>(T[] array, Int32 offset, Int32 count)
			{
				if (array is null)
					throw new ArgumentNullException(nameof(array), ExceptionResources.ArgumentNull);
				if (offset < 0)
					throw new ArgumentOutOfRangeException(nameof(offset), offset, ExceptionResources.ArgumentIsPositive);
				if (count < 0)
					throw new ArgumentOutOfRangeException(nameof(count), count, ExceptionResources.ArgumentIsPositive);
				if ((array.Length > 0 && offset >= array.Length) || (array.Length == 0 && offset > 0))
					throw new ArgumentExceedsUpperLimitException(nameof(offset), offset, array.Length, ExceptionResources.ArgumentIsLessThan);
				if (offset + count > array.Length)
					throw new ArgumentExceedsUpperLimitException(nameof(count), offset + count, array.Length, ExceptionResources.ArgumentIsLessThan);
			}
		}
	}
}
