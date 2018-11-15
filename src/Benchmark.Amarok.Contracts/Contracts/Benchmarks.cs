/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Events
 */

using System;
using BenchmarkDotNet.Attributes;


namespace Amarok.Contracts
{
	[ClrJob, /*CoreJob,*/ MemoryDiagnoser]
	public class Benchmarks
	{
		public Boolean SomeMethod1(String text)
		{
			return text.Length == 123;
		}

		public Boolean SomeMethod2(String text)
		{
			Verify.NotNull(text, nameof(text));
			return text.Length == 123;
		}

		public Boolean SomeMethod3(String text)
		{
			Verify.Debug.NotNull(text, nameof(text));
			return text.Length == 123;
		}

		public Boolean SomeMethod4(String text)
		{
			Verify.Configurable.NotNull(text, nameof(text));
			return text.Length == 123;
		}


		[Benchmark(Baseline = true)]
		public Boolean Baseline()
		{
			return SomeMethod1("abc");
		}

		[Benchmark]
		public Boolean VerifyNotNull()
		{
			return SomeMethod2("abc");
		}

		[Benchmark]
		public Boolean VerifyNotNull_Conditional()
		{
			return SomeMethod3("abc");
		}

		[Benchmark]
		public Boolean VerifyNotNull_Configurable()
		{
			return SomeMethod4("abc");
		}
	}
}
