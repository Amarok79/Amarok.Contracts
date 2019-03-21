﻿/* Copyright(c) 2019, Olaf Kober
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
		public static void IsAssignableTo(Type type, Type targetType, String paramName)
		{
			if (type is null || targetType is null)
				throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
			if (!targetType.IsAssignableFrom(type))
				throw new ArgumentException(ExceptionResources.ArgumentIsAssignableTo, paramName);
		}


		public static partial class Debug
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
			public static void IsAssignableTo(Type type, Type targetType, String paramName)
			{
				if (type is null || targetType is null)
					throw new ArgumentNullException(paramName, ExceptionResources.ArgumentNull);
				if (!targetType.IsAssignableFrom(type))
					throw new ArgumentException(ExceptionResources.ArgumentIsAssignableTo, paramName);
			}
		}
	}
}
