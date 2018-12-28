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
		/// Verifies that the given value is greater than zero, hence, that it is a positive number.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentOutOfRangeException">
		/// Zero or a negative value are not valid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyPositive(Int32 value, String paramName)
		{
			if (value <= 0)
				throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
		}

		/// <summary>
		/// Verifies that the given value is greater than zero, hence, that it is a positive number.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentOutOfRangeException">
		/// Zero or a negative value are not valid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyPositive(Int64 value, String paramName)
		{
			if (value <= 0L)
				throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
		}

		/// <summary>
		/// Verifies that the given value is greater than zero, hence, that it is a positive number.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentOutOfRangeException">
		/// Zero or a negative value are not valid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyPositive(Double value, String paramName)
		{
			if (value <= 0.0d)
				throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
		}

		/// <summary>
		/// Verifies that the given value is greater than zero, hence, that it is a positive number.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentOutOfRangeException">
		/// Zero or a negative value are not valid.</exception>
		[DebuggerStepThrough]
		public static void IsStrictlyPositive(TimeSpan value, String paramName)
		{
			if (value.Ticks <= 0L)
				throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
		}


		public static partial class Debug
		{
			/// <summary>
			/// Verifies that the given value is greater than zero, hence, that it is a positive number.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentOutOfRangeException">
			/// Zero or a negative value are not valid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyPositive(Int32 value, String paramName)
			{
				if (value <= 0)
					throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
			}

			/// <summary>
			/// Verifies that the given value is greater than zero, hence, that it is a positive number.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentOutOfRangeException">
			/// Zero or a negative value are not valid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyPositive(Int64 value, String paramName)
			{
				if (value <= 0L)
					throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
			}

			/// <summary>
			/// Verifies that the given value is greater than zero, hence, that it is a positive number.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentOutOfRangeException">
			/// Zero or a negative value are not valid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyPositive(Double value, String paramName)
			{
				if (value <= 0.0d)
					throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
			}

			/// <summary>
			/// Verifies that the given value is greater than zero, hence, that it is a positive number.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentOutOfRangeException">
			/// Zero or a negative value are not valid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsStrictlyPositive(TimeSpan value, String paramName)
			{
				if (value.Ticks <= 0L)
					throw new ArgumentOutOfRangeException(paramName, value, ExceptionResources.ArgumentIsStrictlyPositive);
			}
		}
	}
}
