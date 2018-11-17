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
		/// Verifies that the given value is neither null nor an empty string.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentNullException">
		/// Null is not a valid value.</exception>
		/// <exception cref="ArgumentException">
		/// An empty string is not a valid value.</exception>
		[DebuggerStepThrough]
		public static void NotEmpty(String value, String paramName)
		{
			if (value is null)
				throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
			if (value.Length == 0)
				throw new ArgumentException(ExceptionResources.ArgumentEmptyString, paramName);
		}


		public static partial class Debug
		{
			/// <summary>
			/// Verifies that the given value is neither null nor an empty string.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentNullException">
			/// Null is not a valid value.</exception>
			/// <exception cref="ArgumentException">
			/// An empty string is not a valid value.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void NotEmpty(String value, String paramName)
			{
				if (value is null)
					throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
				if (value.Length == 0)
					throw new ArgumentException(ExceptionResources.ArgumentEmptyString, paramName);
			}
		}
	}
}
