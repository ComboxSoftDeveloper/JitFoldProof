```

BenchmarkDotNet v0.15.8, Windows 10 (10.0.20348.5139)
Intel Xeon W-2255 CPU 3.70GHz, 1 CPU, 20 logical and 10 physical cores
.NET SDK 11.0.100-preview.6.26359.118
  [Host] : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net10  : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4
  net8   : .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4
  net9   : .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4


```
| Method       | Job   | Toolchain | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|------------- |------ |---------- |----------:|----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| BoxStays     | net10 | net10     | 0.6006 ns | 0.0426 ns | 0.1158 ns | 0.5919 ns |  1.04 |    0.28 |      - |      13 B |         - |          NA |
| BoxEscapes   | net10 | net10     | 6.7015 ns | 0.1526 ns | 0.2829 ns | 6.6249 ns | 11.57 |    2.24 | 0.0024 |      68 B |      24 B |          NA |
| ArrayStays   | net10 | net10     | 1.1396 ns | 0.0533 ns | 0.1039 ns | 1.0953 ns |  1.97 |    0.41 |      - |     104 B |         - |          NA |
| ArrayEscapes | net10 | net10     | 8.1932 ns | 0.1900 ns | 0.2786 ns | 8.1109 ns | 14.15 |    2.71 | 0.0040 |      98 B |      40 B |          NA |
| ArrayOnStack | net10 | net10     | 1.5419 ns | 0.0620 ns | 0.0784 ns | 1.5510 ns |  2.66 |    0.52 |      - |     106 B |         - |          NA |
| BoxStays     | net8  | net8      | 3.5581 ns | 0.0966 ns | 0.2119 ns | 3.5358 ns |  6.14 |    1.22 | 0.0024 |      50 B |      24 B |          NA |
| BoxEscapes   | net8  | net8      | 7.0161 ns | 0.1693 ns | 0.3992 ns | 7.0023 ns | 12.11 |    2.39 | 0.0024 |      68 B |      24 B |          NA |
| ArrayStays   | net8  | net8      | 5.3464 ns | 0.1356 ns | 0.2547 ns | 5.3197 ns |  9.23 |    1.80 | 0.0040 |      71 B |      40 B |          NA |
| ArrayEscapes | net8  | net8      | 8.2642 ns | 0.2009 ns | 0.3186 ns | 8.2119 ns | 14.27 |    2.75 | 0.0040 |      98 B |      40 B |          NA |
| ArrayOnStack | net8  | net8      | 1.7103 ns | 0.0644 ns | 0.1387 ns | 1.6834 ns |  2.95 |    0.61 |      - |     106 B |         - |          NA |
| BoxStays     | net9  | net9      | 0.5226 ns | 0.0412 ns | 0.0642 ns | 0.5090 ns |  0.90 |    0.20 |      - |      13 B |         - |          NA |
| BoxEscapes   | net9  | net9      | 7.0094 ns | 0.1880 ns | 0.5483 ns | 6.9589 ns | 12.10 |    2.48 | 0.0024 |      68 B |      24 B |          NA |
| ArrayStays   | net9  | net9      | 4.8509 ns | 0.1446 ns | 0.4148 ns | 4.7402 ns |  8.38 |    1.74 | 0.0040 |      71 B |      40 B |          NA |
| ArrayEscapes | net9  | net9      | 8.5551 ns | 0.2005 ns | 0.4229 ns | 8.5151 ns | 14.77 |    2.88 | 0.0040 |      98 B |      40 B |          NA |
| ArrayOnStack | net9  | net9      | 1.6040 ns | 0.0637 ns | 0.1574 ns | 1.5511 ns |  2.77 |    0.59 |      - |     106 B |         - |          NA |
