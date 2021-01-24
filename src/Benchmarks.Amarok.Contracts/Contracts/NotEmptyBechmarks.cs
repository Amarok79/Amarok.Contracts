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
    [SimpleJob(RuntimeMoniker.NetCoreApp50), SimpleJob(RuntimeMoniker.Net48), SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class NotEmptyBechmarks
    {
        [Benchmark(Baseline = true)]
        public void Baseline()
        {
            for (var i = 0; i < 1000; i++)
                _BaselineCore("abc");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void _BaselineCore(String text)
        {
        }


        [Benchmark]
        public void Throw()
        {
            for (var i = 0; i < 1000; i++)
                _ThrowCore("abc");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void _ThrowCore(String abc)
        {
            if (abc is null)
                throw new ArgumentNullException(nameof(abc));

            if (abc.Length == 0)
                throw new ArgumentException("msg", nameof(abc));
        }


        [Benchmark]
        public void Verify()
        {
            for (var i = 0; i < 1000; i++)
                _VerifyCore("abc");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void _VerifyCore(String abc)
        {
            Contracts.Verify.NotEmpty(abc, nameof(abc));
        }
    }
}

/*
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.450 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4200.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4200.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


|   Method |           Job |       Runtime |     Mean |     Error |    StdDev | Ratio |
|--------- |-------------- |-------------- |---------:|----------:|----------:|------:|
| Baseline |      .NET 4.8 |      .NET 4.8 | 1.274 us | 0.0030 us | 0.0026 us |  1.00 |
|    Throw |      .NET 4.8 |      .NET 4.8 | 1.528 us | 0.0040 us | 0.0035 us |  1.20 |
|   Verify |      .NET 4.8 |      .NET 4.8 | 1.921 us | 0.0088 us | 0.0082 us |  1.51 |
|          |               |               |          |           |           |       |
| Baseline | .NET Core 3.1 | .NET Core 3.1 | 1.780 us | 0.0046 us | 0.0043 us |  1.00 |
|    Throw | .NET Core 3.1 | .NET Core 3.1 | 1.274 us | 0.0019 us | 0.0017 us |  0.72 |
|   Verify | .NET Core 3.1 | .NET Core 3.1 | 1.786 us | 0.0053 us | 0.0047 us |  1.00 |
*/
