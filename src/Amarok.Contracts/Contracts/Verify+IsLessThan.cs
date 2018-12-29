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
		/// Verifies that the given value is equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// A value exceeding the upper limit is not valid.</exception>
		[DebuggerStepThrough]
		public static void IsLessThan(Int32 value, Int32 upperLimit, String paramName)
		{
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}

		/// <summary>
		/// Verifies that the given value is equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// A value exceeding the upper limit is not valid.</exception>
		[DebuggerStepThrough]
		public static void IsLessThan(Int64 value, Int64 upperLimit, String paramName)
		{
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}

		/// <summary>
		/// Verifies that the given value is equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// A value exceeding the upper limit is not valid.</exception>
		[DebuggerStepThrough]
		public static void IsLessThan(Double value, Double upperLimit, String paramName)
		{
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}

		/// <summary>
		/// Verifies that the given value is equal to or less than the given upper limit.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="upperLimit">
		/// The inclusive upper limit.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentExceedsUpperLimitException">
		/// A value exceeding the upper limit is not valid.</exception>
		[DebuggerStepThrough]
		public static void IsLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
		{
			if (value > upperLimit)
				throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
		}


		public static partial class Debug
		{
			/// <summary>
			/// Verifies that the given value is equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// A value exceeding the upper limit is not valid.</exception>
			[DebuggerStepThrough]
			public static void IsLessThan(Int32 value, Int32 upperLimit, String paramName)
			{
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}

			/// <summary>
			/// Verifies that the given value is equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// A value exceeding the upper limit is not valid.</exception>
			[DebuggerStepThrough]
			public static void IsLessThan(Int64 value, Int64 upperLimit, String paramName)
			{
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}

			/// <summary>
			/// Verifies that the given value is equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// A value exceeding the upper limit is not valid.</exception>
			[DebuggerStepThrough]
			public static void IsLessThan(Double value, Double upperLimit, String paramName)
			{
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}

			/// <summary>
			/// Verifies that the given value is equal to or less than the given upper limit.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="upperLimit">
			/// The inclusive upper limit.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentExceedsUpperLimitException">
			/// A value exceeding the upper limit is not valid.</exception>
			[DebuggerStepThrough]
			public static void IsLessThan(TimeSpan value, TimeSpan upperLimit, String paramName)
			{
				if (value > upperLimit)
					throw new ArgumentExceedsUpperLimitException(paramName, value, upperLimit, ExceptionResources.ArgumentIsLessThan);
			}
		}
	}
}
