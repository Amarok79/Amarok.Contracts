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

using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;


namespace Amarok.Contracts
{
	[SimpleJob(RuntimeMoniker.Net48)]
	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	public class NotNullBechmarks
	{
		[Benchmark(Baseline = true)]
		public void Baseline()
		{
			for (Int32 i = 0; i < 10000; i++)
				_BaselineCore("abc");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _BaselineCore(String text)
		{
		}


		[Benchmark]
		public void Throw()
		{
			for (Int32 i = 0; i < 10000; i++)
				_ThrowCore("abc");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _ThrowCore(String abc)
		{
			if (abc is null)
				throw new ArgumentNullException(nameof(abc));
		}


		[Benchmark]
		public void Verify()
		{
			for (Int32 i = 0; i < 10000; i++)
				_VerifyCore("abc");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void _VerifyCore(String abc)
		{
			Amarok.Contracts.Verify.NotNull(abc, nameof(abc));
		}
	}
}
