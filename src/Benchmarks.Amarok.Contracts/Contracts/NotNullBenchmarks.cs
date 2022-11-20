// Copyright (c) 2022, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable CA1822 // Mark members as static

using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;


namespace Amarok.Contracts;


[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net48)]
public class NotNullBenchmarks
{
    [Benchmark(Baseline = true)]
    public void Baseline()
    {
        for (var i = 0; i < 1000; i++)
        {
            _BaselineCore("abc");
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
#pragma warning disable IDE0060 // Remove unused parameter
    private void _BaselineCore(String text)
#pragma warning restore IDE0060 // Remove unused parameter
    {
    }


    [Benchmark]
    public void Throw()
    {
        for (var i = 0; i < 1000; i++)
        {
            _ThrowCore("abc");
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void _ThrowCore(String abc)
    {
        if (abc is null)
        {
            throw new ArgumentNullException(nameof(abc));
        }
    }


    [Benchmark]
    public void Verify()
    {
        for (var i = 0; i < 1000; i++)
        {
            _VerifyCore("abc");
        }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void _VerifyCore(String abc)
    {
        Contracts.Verify.NotNull(abc, nameof(abc));
    }
}

/*
BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-10875H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
  [Host]             : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256
  .NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256


|   Method |                Job |            Runtime |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------- |------------------- |------------------- |---------:|----------:|----------:|------:|--------:|
| Baseline |           .NET 6.0 |           .NET 6.0 | 1.551 us | 0.0060 us | 0.0053 us |  1.00 |    0.00 |
|    Throw |           .NET 6.0 |           .NET 6.0 | 1.335 us | 0.0063 us | 0.0056 us |  0.86 |    0.00 |
|   Verify |           .NET 6.0 |           .NET 6.0 | 1.333 us | 0.0058 us | 0.0054 us |  0.86 |    0.01 |
|          |                    |                    |          |           |           |       |         |
| Baseline |           .NET 7.0 |           .NET 7.0 | 1.109 us | 0.0054 us | 0.0048 us |  1.00 |    0.00 |
|    Throw |           .NET 7.0 |           .NET 7.0 | 1.352 us | 0.0216 us | 0.0191 us |  1.22 |    0.02 |
|   Verify |           .NET 7.0 |           .NET 7.0 | 1.149 us | 0.0134 us | 0.0126 us |  1.04 |    0.01 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET Framework 4.8 | .NET Framework 4.8 | 1.590 us | 0.0116 us | 0.0108 us |  1.00 |    0.00 |
|    Throw | .NET Framework 4.8 | .NET Framework 4.8 | 1.110 us | 0.0042 us | 0.0037 us |  0.70 |    0.00 |
|   Verify | .NET Framework 4.8 | .NET Framework 4.8 | 1.334 us | 0.0053 us | 0.0047 us |  0.84 |    0.01 |
*/
