```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5386)
Intel Xeon Silver 4314 CPU 2.40GHz, 2 CPU, 64 logical and 32 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.16 (8.0.16, 8.0.1625.21506), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.5 (9.0.5, 9.0.525.21509), X64 RyuJIT x86-64-v4


```
| Method   | Job   | Toolchain | Size  | Mean         | Error       | StdDev      | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|--------- |------ |---------- |------ |-------------:|------------:|------------:|------:|--------:|----------:|----------:|------------:|
| **Numbers**  | **net10** | **net10**     | **64**    |     **196.2 ns** |     **1.56 ns** |     **1.38 ns** |  **1.00** |    **0.01** |     **109 B** |         **-** |          **NA** |
| Words    | net10 | net10     | 64    |     217.3 ns |     3.32 ns |     2.59 ns |  1.11 |    0.01 |     544 B |         - |          NA |
| Objects  | net10 | net10     | 64    |     222.3 ns |     2.21 ns |     1.96 ns |  1.13 |    0.01 |     502 B |         - |          NA |
| Unlisted | net10 | net10     | 64    |     442.4 ns |     5.65 ns |     5.28 ns |  2.25 |    0.03 |     533 B |         - |          NA |
| Numbers  | net8  | net8      | 64    |     175.6 ns |     3.54 ns |     3.64 ns |  0.89 |    0.02 |     111 B |         - |          NA |
| Words    | net8  | net8      | 64    |     222.5 ns |     0.96 ns |     0.85 ns |  1.13 |    0.01 |     546 B |         - |          NA |
| Objects  | net8  | net8      | 64    |     222.5 ns |     2.37 ns |     2.22 ns |  1.13 |    0.01 |     504 B |         - |          NA |
| Unlisted | net8  | net8      | 64    |     468.4 ns |     4.47 ns |     3.96 ns |  2.39 |    0.03 |     535 B |         - |          NA |
| Numbers  | net9  | net9      | 64    |     194.4 ns |     0.78 ns |     0.73 ns |  0.99 |    0.01 |     109 B |         - |          NA |
| Words    | net9  | net9      | 64    |     218.1 ns |     1.87 ns |     1.75 ns |  1.11 |    0.01 |     585 B |         - |          NA |
| Objects  | net9  | net9      | 64    |     223.3 ns |     2.53 ns |     2.24 ns |  1.14 |    0.01 |     542 B |         - |          NA |
| Unlisted | net9  | net9      | 64    |     450.3 ns |     7.93 ns |     8.81 ns |  2.29 |    0.05 |     517 B |         - |          NA |
|          |       |           |       |              |             |             |       |         |           |           |             |
| **Numbers**  | **net10** | **net10**     | **1024**  |   **3,280.7 ns** |    **19.16 ns** |    **17.93 ns** |  **1.00** |    **0.01** |     **109 B** |         **-** |          **NA** |
| Words    | net10 | net10     | 1024  |   2,963.6 ns |    51.04 ns |    47.74 ns |  0.90 |    0.01 |     544 B |         - |          NA |
| Objects  | net10 | net10     | 1024  |   3,326.2 ns |    52.79 ns |    51.84 ns |  1.01 |    0.02 |     502 B |         - |          NA |
| Unlisted | net10 | net10     | 1024  |   6,696.4 ns |    38.35 ns |    35.88 ns |  2.04 |    0.02 |     533 B |         - |          NA |
| Numbers  | net8  | net8      | 1024  |   2,613.2 ns |    52.20 ns |    79.72 ns |  0.80 |    0.02 |     111 B |         - |          NA |
| Words    | net8  | net8      | 1024  |   2,949.1 ns |    53.33 ns |    54.77 ns |  0.90 |    0.02 |     546 B |         - |          NA |
| Objects  | net8  | net8      | 1024  |   3,945.8 ns |    14.13 ns |    12.53 ns |  1.20 |    0.01 |     504 B |         - |          NA |
| Unlisted | net8  | net8      | 1024  |   7,130.2 ns |    41.15 ns |    38.49 ns |  2.17 |    0.02 |     535 B |         - |          NA |
| Numbers  | net9  | net9      | 1024  |   2,930.8 ns |    34.21 ns |    32.00 ns |  0.89 |    0.01 |     109 B |         - |          NA |
| Words    | net9  | net9      | 1024  |   2,912.6 ns |    23.28 ns |    21.77 ns |  0.89 |    0.01 |     585 B |         - |          NA |
| Objects  | net9  | net9      | 1024  |   3,292.7 ns |    14.89 ns |    13.92 ns |  1.00 |    0.01 |     542 B |         - |          NA |
| Unlisted | net9  | net9      | 1024  |   6,686.2 ns |   130.09 ns |   115.32 ns |  2.04 |    0.04 |     517 B |         - |          NA |
|          |       |           |       |              |             |             |       |         |           |           |             |
| **Numbers**  | **net10** | **net10**     | **16384** |  **48,425.4 ns** |   **941.22 ns** | **1,437.34 ns** |  **1.00** |    **0.04** |     **109 B** |         **-** |          **NA** |
| Words    | net10 | net10     | 16384 |  46,880.6 ns |   476.09 ns |   445.33 ns |  0.97 |    0.03 |     544 B |         - |          NA |
| Objects  | net10 | net10     | 16384 |  52,488.4 ns |   301.93 ns |   282.43 ns |  1.08 |    0.03 |     502 B |         - |          NA |
| Unlisted | net10 | net10     | 16384 | 105,686.9 ns | 1,453.72 ns | 1,359.81 ns |  2.18 |    0.07 |     533 B |         - |          NA |
| Numbers  | net8  | net8      | 16384 |  47,093.2 ns |   549.46 ns |   458.82 ns |  0.97 |    0.03 |     111 B |         - |          NA |
| Words    | net8  | net8      | 16384 |  52,785.8 ns |   335.12 ns |   279.84 ns |  1.09 |    0.03 |     546 B |         - |          NA |
| Objects  | net8  | net8      | 16384 |  52,518.0 ns |   403.81 ns |   377.72 ns |  1.09 |    0.03 |     504 B |         - |          NA |
| Unlisted | net8  | net8      | 16384 | 112,355.7 ns | 2,114.55 ns | 1,977.95 ns |  2.32 |    0.08 |     535 B |         - |          NA |
| Numbers  | net9  | net9      | 16384 |  41,136.2 ns |   768.69 ns |   681.42 ns |  0.85 |    0.03 |     109 B |         - |          NA |
| Words    | net9  | net9      | 16384 |  52,518.1 ns |   289.29 ns |   241.57 ns |  1.09 |    0.03 |     585 B |         - |          NA |
| Objects  | net9  | net9      | 16384 |  53,153.6 ns |   582.19 ns |   454.54 ns |  1.10 |    0.03 |     542 B |         - |          NA |
| Unlisted | net9  | net9      | 16384 | 111,009.7 ns | 2,062.33 ns | 2,025.49 ns |  2.29 |    0.08 |     517 B |         - |          NA |
