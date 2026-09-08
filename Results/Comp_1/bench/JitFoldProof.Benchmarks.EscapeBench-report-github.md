```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.19045.6466/22H2/2022Update)
Intel Core i9-10900KF CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host] : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  net10  : .NET 10.0.11 (10.0.11, 10.0.1126.37416), X64 RyuJIT x86-64-v3
  net8   : .NET 8.0.30 (8.0.30, 8.0.3026.36720), X64 RyuJIT x86-64-v3
  net9   : .NET 9.0.19 (9.0.19, 9.0.1926.36724), X64 RyuJIT x86-64-v3


```
| Method       | Job   | Toolchain | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|------------- |------ |---------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| BoxStays     | net10 | net10     | 0.4024 ns | 0.0119 ns | 0.0111 ns | 0.4028 ns |  1.00 |    0.04 |      - |      13 B |         - |          NA |
| BoxEscapes   | net10 | net10     | 4.3016 ns | 0.0473 ns | 0.0443 ns | 4.2874 ns | 10.70 |    0.30 | 0.0023 |      68 B |      24 B |          NA |
| ArrayStays   | net10 | net10     | 0.9318 ns | 0.0073 ns | 0.0069 ns | 0.9283 ns |  2.32 |    0.06 |      - |     104 B |         - |          NA |
| ArrayEscapes | net10 | net10     | 5.6776 ns | 0.0375 ns | 0.0332 ns | 5.6609 ns | 14.12 |    0.38 | 0.0038 |      98 B |      40 B |          NA |
| ArrayOnStack | net10 | net10     | 0.8906 ns | 0.0074 ns | 0.0069 ns | 0.8878 ns |  2.21 |    0.06 |      - |     106 B |         - |          NA |
| BoxStays     | net8  | net8      | 2.4959 ns | 0.0097 ns | 0.0086 ns | 2.4926 ns |  6.21 |    0.17 | 0.0023 |      50 B |      24 B |          NA |
| BoxEscapes   | net8  | net8      | 4.3586 ns | 0.0513 ns | 0.0455 ns | 4.3430 ns | 10.84 |    0.31 | 0.0023 |      68 B |      24 B |          NA |
| ArrayStays   | net8  | net8      | 3.2286 ns | 0.0120 ns | 0.0107 ns | 3.2289 ns |  8.03 |    0.21 | 0.0038 |      71 B |      40 B |          NA |
| ArrayEscapes | net8  | net8      | 5.6466 ns | 0.0148 ns | 0.0131 ns | 5.6453 ns | 14.04 |    0.37 | 0.0038 |      98 B |      40 B |          NA |
| ArrayOnStack | net8  | net8      | 1.0285 ns | 0.0066 ns | 0.0062 ns | 1.0261 ns |  2.56 |    0.07 |      - |     106 B |         - |          NA |
| BoxStays     | net9  | net9      | 0.4101 ns | 0.0074 ns | 0.0066 ns | 0.4096 ns |  1.02 |    0.03 |      - |      13 B |         - |          NA |
| BoxEscapes   | net9  | net9      | 4.3800 ns | 0.0243 ns | 0.0215 ns | 4.3773 ns | 10.89 |    0.29 | 0.0023 |      68 B |      24 B |          NA |
| ArrayStays   | net9  | net9      | 3.1598 ns | 0.0496 ns | 0.0439 ns | 3.1470 ns |  7.86 |    0.23 | 0.0038 |      71 B |      40 B |          NA |
| ArrayEscapes | net9  | net9      | 6.0016 ns | 0.1433 ns | 0.4087 ns | 5.8360 ns | 14.92 |    1.09 | 0.0038 |      98 B |      40 B |          NA |
| ArrayOnStack | net9  | net9      | 1.0700 ns | 0.0196 ns | 0.0174 ns | 1.0649 ns |  2.66 |    0.08 |      - |     106 B |         - |          NA |
