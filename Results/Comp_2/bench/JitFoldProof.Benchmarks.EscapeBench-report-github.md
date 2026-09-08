```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.17763.3165/1809/October2018Update/Redstone5)
AMD Ryzen 9 5950X 3.39GHz, 1 CPU, 32 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.5 (10.0.5, 10.0.526.15411), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.29 (8.0.29, 8.0.2926.32403), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.18 (9.0.18, 9.0.1826.31522), X64 RyuJIT x86-64-v3


```
| Method       | Job   | Toolchain | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|------------- |------ |---------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| BoxStays     | net10 | net10     | 0.5805 ns | 0.1103 ns | 0.3252 ns | 0.5990 ns |  1.48 |    1.36 |      - |      13 B |         - |          NA |
| BoxEscapes   | net10 | net10     | 6.0383 ns | 0.5854 ns | 1.7260 ns | 5.5152 ns | 15.36 |   11.13 | 0.0014 |      68 B |      24 B |          NA |
| ArrayStays   | net10 | net10     | 0.4053 ns | 0.0996 ns | 0.2841 ns | 0.3731 ns |  1.03 |    1.08 |      - |     104 B |         - |          NA |
| ArrayEscapes | net10 | net10     | 8.2174 ns | 0.8745 ns | 2.4808 ns | 7.7353 ns | 20.91 |   15.34 | 0.0024 |      98 B |      40 B |          NA |
| ArrayOnStack | net10 | net10     | 1.3380 ns | 0.2517 ns | 0.7421 ns | 0.9623 ns |  3.40 |    3.12 |      - |     106 B |         - |          NA |
| BoxStays     | net8  | net8      | 4.1591 ns | 0.5444 ns | 1.5706 ns | 3.3569 ns | 10.58 |    8.27 | 0.0014 |      50 B |      24 B |          NA |
| BoxEscapes   | net8  | net8      | 5.9480 ns | 0.5065 ns | 1.4934 ns | 5.3263 ns | 15.13 |   10.69 | 0.0014 |      68 B |      24 B |          NA |
| ArrayStays   | net8  | net8      | 4.1840 ns | 0.3721 ns | 1.0796 ns | 3.8234 ns | 10.64 |    7.56 | 0.0024 |      71 B |      40 B |          NA |
| ArrayEscapes | net8  | net8      | 7.6819 ns | 0.7480 ns | 2.2056 ns | 7.1326 ns | 19.54 |   14.18 | 0.0024 |      98 B |      40 B |          NA |
| ArrayOnStack | net8  | net8      | 1.3929 ns | 0.1280 ns | 0.3610 ns | 1.1783 ns |  3.54 |    2.52 |      - |     106 B |         - |          NA |
| BoxStays     | net9  | net9      | 0.4305 ns | 0.0831 ns | 0.2451 ns | 0.3668 ns |  1.10 |    1.02 |      - |      13 B |         - |          NA |
| BoxEscapes   | net9  | net9      | 6.5206 ns | 0.5598 ns | 1.6505 ns | 6.3217 ns | 16.59 |   11.74 | 0.0014 |      68 B |      24 B |          NA |
| ArrayStays   | net9  | net9      | 4.4339 ns | 0.4815 ns | 1.4197 ns | 3.9235 ns | 11.28 |    8.40 | 0.0024 |      71 B |      40 B |          NA |
| ArrayEscapes | net9  | net9      | 6.9904 ns | 0.4550 ns | 1.3416 ns | 6.9194 ns | 17.78 |   12.09 | 0.0024 |      98 B |      40 B |          NA |
| ArrayOnStack | net9  | net9      | 1.3756 ns | 0.1141 ns | 0.3292 ns | 1.3161 ns |  3.50 |    2.45 |      - |     106 B |         - |          NA |
