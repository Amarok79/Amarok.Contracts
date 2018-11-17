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
		/// Verifies that the given value is not a null reference, hence, that it refers to a valid object.
		/// </summary>
		/// 
		/// <param name="value">
		/// The value to verify.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentNullException">
		/// A null reference was passed to a method that did not accept it as a valid argument.</exception>
		[DebuggerStepThrough]
		public static void NotNull<T>(T value, String paramName)
			where T : class
		{
			if (value is null)
				throw new ArgumentNullException(paramName);
		}


		public static partial class Debug
		{
			/// <summary>
			/// Verifies that the given value is not a null reference, hence, that it refers to a valid object.
			/// </summary>
			/// 
			/// <param name="value">
			/// The value to verify.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentNullException">
			/// A null reference was passed to a method that did not accept it as a valid argument.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void NotNull<T>(T value, String paramName)
				where T : class
			{
				if (value is null)
					throw new ArgumentNullException(paramName);
			}
		}
	}
}
