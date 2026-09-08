using System.Text;
using BenchmarkDotNet.Running;
using JitFoldProof.Benchmarks;
using JitFoldProof.Diagnostics;
using JitFoldProof.Types;

namespace JitFoldProof;

/// <summary>
/// Точка входа. Без аргументов запускаются замеры, с именем отчёта — отчёт.
/// Отчёты печатают в вывод, а батник перенаправляет вывод в файл.
/// </summary>
internal static class Program
{
    /// <summary>Разбор аргументов и запуск.</summary>
    private static int Main(string[] args)
    {
        // Консоль на разных машинах пишет по-разному, а отчёты уезжают
        // в репозиторий одним набором.
        Console.OutputEncoding = Encoding.UTF8;

        string mode = args.Length > 0 ? args[0] : string.Empty;
        return mode switch
        {
            "checks" => Checks.Run(),
            "counters" => Counters.Run(),
            "alloc" => Alloc.Run(),
            "ilsize" => IlSize.Run(),
            "warmup" => Warmup.Run(),
            "timing" => Timing.Run(),
            _ => Bench(args)
        };
    }

    /// <summary>
    /// Запуск замеров. Свой аргумент один — noasm, он выключает снятие
    /// машинного кода. Остальные уходят в BenchmarkDotNet как есть.
    /// </summary>
    private static int Bench(string[] args)
    {
        bool disassembly = !args.Contains("noasm");
        string[] rest = args.Where(argument => argument != "noasm").ToArray();

        BenchmarkSwitcher
            .FromTypes([
                typeof(ConstantBench),
                typeof(ClearBench),
                typeof(GenericBench),
                typeof(TierBench),
                typeof(EscapeBench),
            ])
            .Run(rest, new BenchmarkConfig(disassembly));

        return 0;
    }
}
