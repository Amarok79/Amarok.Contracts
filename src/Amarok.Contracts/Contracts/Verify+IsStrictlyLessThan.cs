/* Copyright(c) 2019, Olaf Kober
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
		/// Verifies that the given value is less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The exclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the exclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyLessThan(Int32 value, Int32 upperLimit, String paramName)
		{
			if (value >= upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
		}

		/// <summary>
		/// Verifies that the given value is less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The exclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the exclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyLessThan(Int64 value, Int64 upperLimit, String paramName)
		{
			if (value >= upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
		}

		/// <summary>
		/// Verifies that the given value is less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The exclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the exclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyLessThan(Double value, Double upperLimit, String paramName)
		{
			if (value >= upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
		}

		/// <summary>
		/// Verifies that the given value is less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The exclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the exclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
		{
			if (value >= upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
		}


		public static partial class Debug
		{
			/// <summary>
			/// Verifies that the given value is less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The exclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the exclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyLessThan(Int32 value, Int32 upperLimit, String paramName)
			{
				if (value >= upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
			}

			/// <summary>
			/// Verifies that the given value is less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The exclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the exclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyLessThan(Int64 value, Int64 upperLimit, String paramName)
			{
				if (value >= upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
			}

			/// <summary>
			/// Verifies that the given value is less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The exclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the exclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyLessThan(Double value, Double upperLimit, String paramName)
			{
				if (value >= upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
			}

			/// <summary>
			/// Verifies that the given value is less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The exclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the exclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
			{
				if (value >= upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsStrictlyLessThan);
			}
		}
	}
}
