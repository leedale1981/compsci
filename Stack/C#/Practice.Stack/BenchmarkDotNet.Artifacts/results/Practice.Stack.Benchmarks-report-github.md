```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22635.4655)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.111
  [Host] : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=MediumRun  Toolchain=InProcessNoEmitToolchain  IterationCount=15  
LaunchCount=2  WarmupCount=10  

```
| Method                           | Mean      | Error     | StdDev    | Median    | Gen0    | Gen1   | Allocated |
|--------------------------------- |----------:|----------:|----------:|----------:|--------:|-------:|----------:|
| BenchmarkCustomStack             |  2.614 μs | 0.0490 μs | 0.0687 μs |  2.617 μs |  1.6594 | 0.0343 |  10.19 KB |
| BenchmarkBclStack                |  7.870 μs | 0.1094 μs | 0.1533 μs |  7.982 μs |  7.1106 | 0.6409 |  43.58 KB |
| BenchmarkBclStackWithParsedValue | 23.132 μs | 0.1032 μs | 0.1513 μs | 23.095 μs | 10.6812 | 0.9460 |  65.45 KB |
