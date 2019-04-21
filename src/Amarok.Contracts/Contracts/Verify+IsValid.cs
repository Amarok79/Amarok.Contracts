/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members

using System;
using System.Diagnostics;


namespace Amarok.Contracts
{
	public partial class Verify
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
		public static void IsValid<T>(T[] array, Int32 count)
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
		public static void IsValid<T>(T[] array, Int32 offset, Int32 count)
		{
			if (array is null)
				throw new ArgumentNullException(nameof(array), ExceptionResources.ArgumentNull);
			if (offset < 0)
				throw new ArgumentOutOfRangeException(nameof(offset), offset, ExceptionResources.ArgumentIsPositive);
			if (count < 0)
				throw new ArgumentOutOfRangeException(nameof(count), count, ExceptionResources.ArgumentIsPositive);
			if (array.Length > 0 && offset >= array.Length || array.Length == 0 && offset > 0)
				throw new ArgumentExceedsUpperLimitException(nameof(offset), offset, array.Length, ExceptionResources.ArgumentIsLessThan);
			if (offset + count > array.Length)
				throw new ArgumentExceedsUpperLimitException(nameof(count), offset + count, array.Length, ExceptionResources.ArgumentIsLessThan);
		}

		public static partial class Debug
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
			public static void IsValid<T>(T[] array, Int32 count)
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
			public static void IsValid<T>(T[] array, Int32 offset, Int32 count)
			{
				if (array is null)
					throw new ArgumentNullException(nameof(array), ExceptionResources.ArgumentNull);
				if (offset < 0)
					throw new ArgumentOutOfRangeException(nameof(offset), offset, ExceptionResources.ArgumentIsPositive);
				if (count < 0)
					throw new ArgumentOutOfRangeException(nameof(count), count, ExceptionResources.ArgumentIsPositive);
				if (array.Length > 0 && offset >= array.Length || array.Length == 0 && offset > 0)
					throw new ArgumentExceedsUpperLimitException(nameof(offset), offset, array.Length, ExceptionResources.ArgumentIsLessThan);
				if (offset + count > array.Length)
					throw new ArgumentExceedsUpperLimitException(nameof(count), offset + count, array.Length, ExceptionResources.ArgumentIsLessThan);
			}
		}
	}
}
