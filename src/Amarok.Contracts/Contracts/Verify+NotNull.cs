/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Contracts
 */

#pragma warning disable S3218 // Inner class members should not shadow outer class "static" or type members
#pragma warning disable S3963 // "static" fields should be initialized inline

using System;
using System.Diagnostics;


namespace Amarok.Contracts
{
	public partial class Verify
	{
		/// <summary>
		/// </summary>
		public static void NotNull<T>(T value, String paramName)
			where T : class
		{
			if (value is null)
				throw new ArgumentNullException(paramName);
		}


		/// <summary>
		/// </summary>
		public static class Debug
		{
			/// <summary>
			/// </summary>
			[Conditional("DEBUG")]
			public static void NotNull<T>(T value, String paramName)
				where T : class
			{
				if (value is null)
					throw new ArgumentNullException(paramName);
			}
		}

		/// <summary>
		/// </summary>
		public static class Configurable
		{
			private static Boolean sIsEnabled;

			static Configurable()
			{
				sIsEnabled = Environment.GetEnvironmentVariable("abc") != null;
			}

			/// <summary>
			/// </summary>
			public static void NotNull<T>(T value, String paramName)
					where T : class
			{
				if (!sIsEnabled)
					return;
				Verify.NotNull(value, paramName);
			}
		}

	}
}
