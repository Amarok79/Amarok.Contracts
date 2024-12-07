// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable CA1822 // Mark members as static

using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;


namespace Amarok.Contracts;


[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.Net80)]
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
            throw new ArgumentNullException(nameof(abc));
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
BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
Intel Core i7-10875H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
  [Host]             : .NET Framework 4.8.1 (4.8.9241.0), X64 RyuJIT VectorSize=256
  .NET 6.0           : .NET 6.0.31 (6.0.3124.26714), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.20 (7.0.2024.26716), X64 RyuJIT AVX2
  .NET 8.0           : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9241.0), X64 RyuJIT VectorSize=256


| Method   | Job                | Runtime            | Mean     | Error     | StdDev    | Ratio | RatioSD |
|--------- |------------------- |------------------- |---------:|----------:|----------:|------:|--------:|
| Baseline | .NET 6.0           | .NET 6.0           | 1.680 us | 0.0044 us | 0.0037 us |  1.00 |    0.00 |
| Throw    | .NET 6.0           | .NET 6.0           | 1.502 us | 0.0287 us | 0.0268 us |  0.90 |    0.01 |
| Verify   | .NET 6.0           | .NET 6.0           | 1.493 us | 0.0285 us | 0.0279 us |  0.89 |    0.02 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET 7.0           | .NET 7.0           | 1.262 us | 0.0028 us | 0.0023 us |  1.00 |    0.00 |
| Throw    | .NET 7.0           | .NET 7.0           | 1.108 us | 0.0169 us | 0.0158 us |  0.88 |    0.01 |
| Verify   | .NET 7.0           | .NET 7.0           | 1.128 us | 0.0087 us | 0.0081 us |  0.90 |    0.01 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET 8.0           | .NET 8.0           | 1.057 us | 0.0050 us | 0.0045 us |  1.00 |    0.00 |
| Throw    | .NET 8.0           | .NET 8.0           | 1.103 us | 0.0169 us | 0.0158 us |  1.04 |    0.01 |
| Verify   | .NET 8.0           | .NET 8.0           | 1.324 us | 0.0195 us | 0.0173 us |  1.25 |    0.01 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET Framework 4.8 | .NET Framework 4.8 | 1.261 us | 0.0037 us | 0.0031 us |  1.00 |    0.00 |
| Throw    | .NET Framework 4.8 | .NET Framework 4.8 | 1.309 us | 0.0128 us | 0.0119 us |  1.04 |    0.01 |
| Verify   | .NET Framework 4.8 | .NET Framework 4.8 | 1.505 us | 0.0296 us | 0.0443 us |  1.19 |    0.04 |
*/
