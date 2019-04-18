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
		/// Verifies that the given value is equal to or greater than the given lower limit and 
		/// equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="lowerLimit">
		/// The inclusive lower limit.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsLowerLimitException">
		/// Values exceeding the inclusive lower limit are invalid.</exception>
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the inclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsInRange(Int32 value, Int32 lowerLimit, Int32 upperLimit, String paramName)
		{
			if (value < lowerLimit)
				throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}

		/// <summary>
		/// Verifies that the given value is equal to or greater than the given lower limit and 
		/// equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="lowerLimit">
		/// The inclusive lower limit.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsLowerLimitException">
		/// Values exceeding the inclusive lower limit are invalid.</exception>
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the inclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsInRange(Int64 value, Int64 lowerLimit, Int64 upperLimit, String paramName)
		{
			if (value < lowerLimit)
				throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}

		/// <summary>
		/// Verifies that the given value is equal to or greater than the given lower limit and 
		/// equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="lowerLimit">
		/// The inclusive lower limit.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsLowerLimitException">
		/// Values exceeding the inclusive lower limit are invalid.</exception>
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the inclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsInRange(Double value, Double lowerLimit, Double upperLimit, String paramName)
		{
			if (value < lowerLimit)
				throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}

		/// <summary>
		/// Verifies that the given value is equal to or greater than the given lower limit and 
		/// equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="lowerLimit">
		/// The inclusive lower limit.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsLowerLimitException">
		/// Values exceeding the inclusive lower limit are invalid.</exception>
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// Values exceeding the inclusive upper limit are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsInRange(TimeSpan value, TimeSpan lowerLimit, TimeSpan upperLimit, String paramName)
		{
			if (value < lowerLimit)
				throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}


		public static partial class Debug
		{
			/// <summary>
			/// Verifies that the given value is equal to or greater than the given lower limit and 
			/// equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="lowerLimit">
			/// The inclusive lower limit.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsLowerLimitException">
			/// Values exceeding the inclusive lower limit are invalid.</exception>
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the inclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsInRange(Int32 value, Int32 lowerLimit, Int32 upperLimit, String paramName)
			{
				if (value < lowerLimit)
					throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}

			/// <summary>
			/// Verifies that the given value is equal to or greater than the given lower limit and 
			/// equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="lowerLimit">
			/// The inclusive lower limit.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsLowerLimitException">
			/// Values exceeding the inclusive lower limit are invalid.</exception>
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the inclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsInRange(Int64 value, Int64 lowerLimit, Int64 upperLimit, String paramName)
			{
				if (value < lowerLimit)
					throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}

			/// <summary>
			/// Verifies that the given value is equal to or greater than the given lower limit and 
			/// equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="lowerLimit">
			/// The inclusive lower limit.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsLowerLimitException">
			/// Values exceeding the inclusive lower limit are invalid.</exception>
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the inclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsInRange(Double value, Double lowerLimit, Double upperLimit, String paramName)
			{
				if (value < lowerLimit)
					throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}

			/// <summary>
			/// Verifies that the given value is equal to or greater than the given lower limit and 
			/// equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="lowerLimit">
			/// The inclusive lower limit.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsLowerLimitException">
			/// Values exceeding the inclusive lower limit are invalid.</exception>
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// Values exceeding the inclusive upper limit are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsInRange(TimeSpan value, TimeSpan lowerLimit, TimeSpan upperLimit, String paramName)
			{
				if (value < lowerLimit)
					throw new ArgumentExceedsLowerLimitException(paramName, value, lowerLimit, ExceptionResources.ArgumentIsGreaterThan);
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}
		}
	}
}
