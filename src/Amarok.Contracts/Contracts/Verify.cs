/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

#pragma warning disable S2292 // Trivial properties should be auto-implemented

using System;


namespace Amarok.Contracts
{
	/// <summary>
	/// This type provides static methods for argument verification.
	/// </summary>
	public static partial class Verify
	{
		/// <summary>
		/// This nested type provides the same static methods for argument verification as the parent type, except 
		/// that these nested methods are all annotated with <c>[Conditional("DEBUG")]</c>, meaning these methods 
		/// are only compiled into the output assembly if the compiler define <c>DEBUG</c> is present.
		/// </summary>
		public static partial class Debug
		{
		}

		/// <summary>
		/// This nested type provides the same static methods for argument verification as the parent type, except
		/// that these nested methods can be switched on and off. By default verification is switched off and thus
		/// induces only a small runtime overhead. By setting environment variable <c>AMAROK_CONTRACTS_ENABLED</c>
		/// or by programmatically setting <see cref="IsEnabled"/> to true, verification can be switched on.
		/// </summary>
		public static partial class Configurable
		{
			// static data
			private static Boolean sIsEnabled = Environment.GetEnvironmentVariable("AMAROK_CONTRACTS_ENABLED") != null;


			/// <summary>
			/// A boolean value indicating whether verification is enabled.
			/// </summary>
			public static Boolean IsEnabled
			{
				get => sIsEnabled;
				set => sIsEnabled = value;
			}
		}
	}
}
