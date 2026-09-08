```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3


```
| Method   | Job   | Toolchain | Size  | Mean        | Error     | StdDev    | Ratio | RatioSD | Code Size | Allocated | Alloc Ratio |
|--------- |------ |---------- |------ |------------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
| **Numbers**  | **net10** | **net10**     | **64**    |    **120.6 ns** |   **1.09 ns** |   **0.97 ns** |  **1.00** |    **0.01** |     **109 B** |         **-** |          **NA** |
| Words    | net10 | net10     | 64    |    134.9 ns |   1.23 ns |   1.15 ns |  1.12 |    0.01 |     544 B |         - |          NA |
| Objects  | net10 | net10     | 64    |    148.4 ns |   0.75 ns |   0.70 ns |  1.23 |    0.01 |     502 B |         - |          NA |
| Unlisted | net10 | net10     | 64    |    261.9 ns |   3.70 ns |   3.46 ns |  2.17 |    0.03 |     533 B |         - |          NA |
| Numbers  | net8  | net8      | 64    |    133.8 ns |   0.97 ns |   0.90 ns |  1.11 |    0.01 |     111 B |         - |          NA |
| Words    | net8  | net8      | 64    |    133.7 ns |   0.84 ns |   0.79 ns |  1.11 |    0.01 |     546 B |         - |          NA |
| Objects  | net8  | net8      | 64    |    150.0 ns |   0.47 ns |   0.44 ns |  1.24 |    0.01 |     504 B |         - |          NA |
| Unlisted | net8  | net8      | 64    |    262.8 ns |   1.44 ns |   1.35 ns |  2.18 |    0.02 |     535 B |         - |          NA |
| Numbers  | net9  | net9      | 64    |    133.1 ns |   0.39 ns |   0.34 ns |  1.10 |    0.01 |     109 B |         - |          NA |
| Words    | net9  | net9      | 64    |    134.3 ns |   0.40 ns |   0.36 ns |  1.11 |    0.01 |     585 B |         - |          NA |
| Objects  | net9  | net9      | 64    |    147.6 ns |   0.26 ns |   0.23 ns |  1.22 |    0.01 |     542 B |         - |          NA |
| Unlisted | net9  | net9      | 64    |    262.4 ns |   1.10 ns |   1.03 ns |  2.18 |    0.02 |     517 B |         - |          NA |
|          |       |           |       |             |           |           |       |         |           |           |             |
| **Numbers**  | **net10** | **net10**     | **1024**  |  **2,051.8 ns** |   **6.89 ns** |   **5.75 ns** |  **1.00** |    **0.00** |     **109 B** |         **-** |          **NA** |
| Words    | net10 | net10     | 1024  |  2,266.4 ns |   6.92 ns |   6.47 ns |  1.10 |    0.00 |     544 B |         - |          NA |
| Objects  | net10 | net10     | 1024  |  2,270.7 ns |   7.00 ns |   6.55 ns |  1.11 |    0.00 |     502 B |         - |          NA |
| Unlisted | net10 | net10     | 1024  |  4,123.4 ns |  15.72 ns |  14.71 ns |  2.01 |    0.01 |     533 B |         - |          NA |
| Numbers  | net8  | net8      | 1024  |  2,453.1 ns |  22.14 ns |  20.71 ns |  1.20 |    0.01 |     111 B |         - |          NA |
| Words    | net8  | net8      | 1024  |  2,257.0 ns |   7.99 ns |   6.67 ns |  1.10 |    0.00 |     546 B |         - |          NA |
| Objects  | net8  | net8      | 1024  |  2,254.7 ns |   7.71 ns |   6.84 ns |  1.10 |    0.00 |     504 B |         - |          NA |
| Unlisted | net8  | net8      | 1024  |  4,108.9 ns |  22.14 ns |  20.71 ns |  2.00 |    0.01 |     535 B |         - |          NA |
| Numbers  | net9  | net9      | 1024  |  2,459.6 ns |  11.07 ns |  10.35 ns |  1.20 |    0.01 |     109 B |         - |          NA |
| Words    | net9  | net9      | 1024  |  2,234.6 ns |   7.54 ns |   7.06 ns |  1.09 |    0.00 |     585 B |         - |          NA |
| Objects  | net9  | net9      | 1024  |  2,236.0 ns |   2.40 ns |   2.13 ns |  1.09 |    0.00 |     542 B |         - |          NA |
| Unlisted | net9  | net9      | 1024  |  3,859.5 ns |  15.42 ns |  14.42 ns |  1.88 |    0.01 |     517 B |         - |          NA |
|          |       |           |       |             |           |           |       |         |           |           |             |
| **Numbers**  | **net10** | **net10**     | **16384** | **32,804.9 ns** | **388.82 ns** | **363.71 ns** |  **1.00** |    **0.02** |     **109 B** |         **-** |          **NA** |
| Words    | net10 | net10     | 16384 | 36,106.1 ns | 187.51 ns | 175.40 ns |  1.10 |    0.01 |     544 B |         - |          NA |
| Objects  | net10 | net10     | 16384 | 36,066.6 ns | 318.36 ns | 297.80 ns |  1.10 |    0.01 |     502 B |         - |          NA |
| Unlisted | net10 | net10     | 16384 | 65,870.8 ns | 777.68 ns | 727.44 ns |  2.01 |    0.03 |     533 B |         - |          NA |
| Numbers  | net8  | net8      | 16384 | 38,683.7 ns | 494.48 ns | 462.54 ns |  1.18 |    0.02 |     111 B |         - |          NA |
| Words    | net8  | net8      | 16384 | 35,804.1 ns | 194.38 ns | 181.82 ns |  1.09 |    0.01 |     546 B |         - |          NA |
| Objects  | net8  | net8      | 16384 | 36,222.4 ns | 414.64 ns | 387.86 ns |  1.10 |    0.02 |     504 B |         - |          NA |
| Unlisted | net8  | net8      | 16384 | 66,130.7 ns | 799.45 ns | 747.80 ns |  2.02 |    0.03 |     535 B |         - |          NA |
| Numbers  | net9  | net9      | 16384 | 38,546.3 ns | 241.13 ns | 225.55 ns |  1.18 |    0.01 |     109 B |         - |          NA |
| Words    | net9  | net9      | 16384 | 36,131.4 ns | 180.14 ns | 168.50 ns |  1.10 |    0.01 |     585 B |         - |          NA |
| Objects  | net9  | net9      | 16384 | 36,569.8 ns | 547.50 ns | 485.35 ns |  1.11 |    0.02 |     542 B |         - |          NA |
| Unlisted | net9  | net9      | 16384 | 62,300.5 ns | 889.82 ns | 832.34 ns |  1.90 |    0.03 |     517 B |         - |          NA |
