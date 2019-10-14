/* Copyright(c) 2019, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

namespace Amarok.Contracts
{
	/// <summary>
	/// This type provides static methods for argument verification.
	/// </summary>
	public static partial class Verify
	{
		/// <summary>
		/// This nested type provides the same static methods for argument verification as the parent type, 
		/// except that these nested methods are all annotated with <c>[Conditional("DEBUG")]</c>, meaning 
		/// these methods are only compiled into the output assembly, if the compiler define <c>DEBUG</c> 
		/// is present.
		/// </summary>
		public static partial class Debug
		{
		}
	}
}
