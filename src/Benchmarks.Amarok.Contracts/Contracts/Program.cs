﻿// Copyright (c) 2024, Olaf Kober <olaf.kober@outlook.com>

using BenchmarkDotNet.Running;


namespace Amarok.Contracts;


public static class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<NotNullBenchmarks>();
        BenchmarkRunner.Run<NotEmptyBenchmarks>();
    }
}
