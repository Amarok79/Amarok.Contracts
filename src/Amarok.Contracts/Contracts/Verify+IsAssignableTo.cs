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
		/// Verifies that the given type is not null and assignable to the specified target type.
		/// </summary>
		/// 
		/// <param name="type">
		/// The type to verify.</param>
		/// <param name="targetType">
		/// The expected target type.</param>
		/// <param name="paramName">
		/// The name of the method parameter that is verified.</param>
		/// 
		/// <exception cref="ArgumentNullException">
		/// Null values are invalid.</exception>
		/// <exception cref="ArgumentException">
		/// Types not assignable to a specific type are invalid.</exception>
		[DebuggerStepThrough]
		public static void IsAssignableTo(Type? type, Type targetType, String paramName)
		{
			if (type is null || targetType is null)
				throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
			if (!targetType.IsAssignableFrom(type))
				throw new ArgumentException(ExceptionResources.ArgumentIsAssignableTo, paramName);
		}


		internal static partial class Debug
		{
			/// <summary>
			/// Verifies that the given type is not null and assignable to the specified target type.
			/// </summary>
			/// 
			/// <param name="type">
			/// The type to verify.</param>
			/// <param name="targetType">
			/// The expected target type.</param>
			/// <param name="paramName">
			/// The name of the method parameter that is verified.</param>
			/// 
			/// <exception cref="ArgumentNullException">
			/// Null values are invalid.</exception>
			/// <exception cref="ArgumentException">
			/// Types not assignable to a specific type are invalid.</exception>
			[Conditional("DEBUG")]
			[DebuggerStepThrough]
			public static void IsAssignableTo(Type? type, Type targetType, String paramName)
			{
				if (type is null || targetType is null)
					throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
				if (!targetType.IsAssignableFrom(type))
					throw new ArgumentException(ExceptionResources.ArgumentIsAssignableTo, paramName);
			}
		}
	}
}
