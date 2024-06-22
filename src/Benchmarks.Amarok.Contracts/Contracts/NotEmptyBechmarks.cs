// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

#pragma warning disable CA1822 // Mark members as static

using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;


namespace Amarok.Contracts;


[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net70)]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net48)]
public class NotEmptyBenchmarks
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

        if (abc.Length == 0)
        {
            throw new ArgumentException("msg", nameof(abc));
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
        Contracts.Verify.NotEmpty(abc, nameof(abc));
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
| Baseline | .NET 6.0           | .NET 6.0           | 1.487 us | 0.0138 us | 0.0122 us |  1.00 |    0.00 |
| Throw    | .NET 6.0           | .NET 6.0           | 1.551 us | 0.0303 us | 0.0283 us |  1.04 |    0.02 |
| Verify   | .NET 6.0           | .NET 6.0           | 1.543 us | 0.0274 us | 0.0256 us |  1.04 |    0.02 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET 7.0           | .NET 7.0           | 1.269 us | 0.0065 us | 0.0057 us |  1.00 |    0.00 |
| Throw    | .NET 7.0           | .NET 7.0           | 1.355 us | 0.0163 us | 0.0144 us |  1.07 |    0.01 |
| Verify   | .NET 7.0           | .NET 7.0           | 1.337 us | 0.0259 us | 0.0255 us |  1.05 |    0.02 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET 8.0           | .NET 8.0           | 1.138 us | 0.0227 us | 0.0415 us |  1.00 |    0.00 |
| Throw    | .NET 8.0           | .NET 8.0           | 1.414 us | 0.0270 us | 0.0265 us |  1.22 |    0.06 |
| Verify   | .NET 8.0           | .NET 8.0           | 1.609 us | 0.0244 us | 0.0228 us |  1.39 |    0.08 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET Framework 4.8 | .NET Framework 4.8 | 1.268 us | 0.0065 us | 0.0061 us |  1.00 |    0.00 |
| Throw    | .NET Framework 4.8 | .NET Framework 4.8 | 1.348 us | 0.0161 us | 0.0150 us |  1.06 |    0.01 |
| Verify   | .NET Framework 4.8 | .NET Framework 4.8 | 1.352 us | 0.0257 us | 0.0285 us |  1.06 |    0.02 |
*/
