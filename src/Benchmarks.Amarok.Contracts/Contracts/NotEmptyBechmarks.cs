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
BenchmarkDotNet=v0.13.2, OS=Windows 11 (10.0.22621.819)
Intel Core i7-10875H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
  [Host]             : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256
  .NET 6.0           : .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
  .NET 7.0           : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  .NET Framework 4.8 : .NET Framework 4.8.1 (4.8.9105.0), X64 RyuJIT VectorSize=256


|   Method |                Job |            Runtime |     Mean |     Error |    StdDev | Ratio | RatioSD |
|--------- |------------------- |------------------- |---------:|----------:|----------:|------:|--------:|
| Baseline |           .NET 6.0 |           .NET 6.0 | 1.548 us | 0.0057 us | 0.0051 us |  1.00 |    0.00 |
|    Throw |           .NET 6.0 |           .NET 6.0 | 1.336 us | 0.0082 us | 0.0073 us |  0.86 |    0.01 |
|   Verify |           .NET 6.0 |           .NET 6.0 | 1.551 us | 0.0059 us | 0.0055 us |  1.00 |    0.00 |
|          |                    |                    |          |           |           |       |         |
| Baseline |           .NET 7.0 |           .NET 7.0 | 1.205 us | 0.0238 us | 0.0275 us |  1.00 |    0.00 |
|    Throw |           .NET 7.0 |           .NET 7.0 | 1.484 us | 0.0280 us | 0.0275 us |  1.24 |    0.03 |
|   Verify |           .NET 7.0 |           .NET 7.0 | 1.426 us | 0.0278 us | 0.0285 us |  1.19 |    0.05 |
|          |                    |                    |          |           |           |       |         |
| Baseline | .NET Framework 4.8 | .NET Framework 4.8 | 1.603 us | 0.0070 us | 0.0062 us |  1.00 |    0.00 |
|    Throw | .NET Framework 4.8 | .NET Framework 4.8 | 1.231 us | 0.0236 us | 0.0231 us |  0.77 |    0.02 |
|   Verify | .NET Framework 4.8 | .NET Framework 4.8 | 1.409 us | 0.0225 us | 0.0210 us |  0.88 |    0.01 |
*/
