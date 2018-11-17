/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Amarok.Contracts
 */

#define DEBUG

using System;
using BenchmarkDotNet.Attributes;


namespace Amarok.Contracts
{
	[ClrJob, /*CoreJob, MemoryDiagnoser*/]
	public class Benchmarks_NotNull
	{
		public void TestMethodUsingVerify(String text)
		{
			Verify.NotNull(text, nameof(text));
			Verify.NotNull(text, nameof(text));
			Verify.NotNull(text, nameof(text));
		}

		public void TestMethodUsingVerifyDebug(String text)
		{
			Verify.Debug.NotNull(text, nameof(text));
			Verify.Debug.NotNull(text, nameof(text));
			Verify.Debug.NotNull(text, nameof(text));
		}


		[Benchmark(Baseline = true)]
		public void Verify_NotNull()
		{
			TestMethodUsingVerify("abc");
		}

		[Benchmark]
		public void Verify_Debug_NotNull()
		{
			TestMethodUsingVerifyDebug("abc");
		}
	}
}
