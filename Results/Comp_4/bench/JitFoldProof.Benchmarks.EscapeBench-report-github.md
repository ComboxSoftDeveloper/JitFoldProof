```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method       | Job   | Toolchain | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|------------- |------ |---------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| BoxStays     | net10 | net10     | 0.7362 ns | 0.0520 ns | 0.0487 ns |  1.00 |    0.09 |      - |      13 B |         - |          NA |
| BoxEscapes   | net10 | net10     | 8.2448 ns | 0.1203 ns | 0.1067 ns | 11.24 |    0.69 | 0.0019 |      63 B |      24 B |          NA |
| ArrayStays   | net10 | net10     | 1.1331 ns | 0.0391 ns | 0.0365 ns |  1.54 |    0.10 |      - |     104 B |         - |          NA |
| ArrayEscapes | net10 | net10     | 9.5997 ns | 0.2202 ns | 0.2163 ns | 13.09 |    0.83 | 0.0032 |      93 B |      40 B |          NA |
| ArrayOnStack | net10 | net10     | 1.7995 ns | 0.0300 ns | 0.0280 ns |  2.45 |    0.15 |      - |     106 B |         - |          NA |
| BoxStays     | net8  | net8      | 4.6690 ns | 0.1309 ns | 0.2900 ns |  6.37 |    0.55 | 0.0019 |      50 B |      24 B |          NA |
| BoxEscapes   | net8  | net8      | 8.0200 ns | 0.1963 ns | 0.3171 ns | 10.93 |    0.78 | 0.0019 |      63 B |      24 B |          NA |
| ArrayStays   | net8  | net8      | 7.8324 ns | 0.1872 ns | 0.3422 ns | 10.68 |    0.79 | 0.0032 |      71 B |      40 B |          NA |
| ArrayEscapes | net8  | net8      | 8.9275 ns | 0.2152 ns | 0.3350 ns | 12.17 |    0.86 | 0.0032 |      93 B |      40 B |          NA |
| ArrayOnStack | net8  | net8      | 1.8119 ns | 0.0488 ns | 0.0407 ns |  2.47 |    0.16 |      - |     106 B |         - |          NA |
| BoxStays     | net9  | net9      | 0.7383 ns | 0.0124 ns | 0.0104 ns |  1.01 |    0.06 |      - |      13 B |         - |          NA |
| BoxEscapes   | net9  | net9      | 8.1315 ns | 0.1819 ns | 0.1613 ns | 11.09 |    0.70 | 0.0019 |      63 B |      24 B |          NA |
| ArrayStays   | net9  | net9      | 5.8660 ns | 0.1211 ns | 0.1296 ns |  8.00 |    0.51 | 0.0032 |      71 B |      40 B |          NA |
| ArrayEscapes | net9  | net9      | 9.1450 ns | 0.2039 ns | 0.1908 ns | 12.47 |    0.79 | 0.0032 |      93 B |      40 B |          NA |
| ArrayOnStack | net9  | net9      | 1.6358 ns | 0.0288 ns | 0.0269 ns |  2.23 |    0.14 |      - |     106 B |         - |          NA |
