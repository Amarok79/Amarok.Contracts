/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

using BenchmarkDotNet.Running;


namespace Amarok.Contracts
{
	public static class Program
	{
		public static void Main()
		{
			BenchmarkRunner.Run<Benchmarks_NotNull>();
		}
	}
}
