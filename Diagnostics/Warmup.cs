using System.Diagnostics;
using JitFoldProof.Types;

namespace JitFoldProof.Diagnostics;

/// <summary>
/// Уровни компиляции. Один и тот же метод вызывается партиями, время каждой
/// партии выводится. Ступенька в середине ряда — переход на второй уровень:
/// до неё выполняется один машинный код, после неё другой.
///
/// Это единственный способ показать раздел 5 числами. BenchmarkDotNet
/// прогревает метод до замера и ступеньку не показывает никогда.
/// </summary>
internal static class Warmup
{
    /// <summary>Выводит ряд времён по партиям.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine("Многоуровневая компиляция: " + Setting("DOTNET_TieredCompilation"));
        Console.WriteLine("Готовый машинный код: " + Setting("DOTNET_ReadyToRun"));
        Console.WriteLine("Динамический профиль: " + Setting("DOTNET_TieredPGO"));
        Console.WriteLine();
        Console.WriteLine("Партия по " + Batch + " вызовов, тики на партию:");
        Console.WriteLine();

        int[] data = Payloads.Numbers(1024);
        long[] ticks = new long[Batches];

        Stopwatch watch = new();
        for (int batch = 0; batch < Batches; batch++)
        {
            watch.Restart();

            int sum = 0;
            for (int i = 0; i < Batch; i++)
            {
                sum += Subjects.SumGuarded(data);
            }

            watch.Stop();
            ticks[batch] = watch.ElapsedTicks;

            // Результат складывается в вывод: иначе цикл целиком мёртвый
            // и JIT вправе его удалить.
            if (sum == int.MinValue)
            {
                Console.WriteLine("недостижимо");
            }
        }

        for (int batch = 0; batch < Batches; batch++)
        {
            Console.WriteLine("  партия " +
                (batch + 1).ToString(System.Globalization.CultureInfo.InvariantCulture).PadLeft(3) +
                "  " + ticks[batch].ToString("N0", System.Globalization.CultureInfo.InvariantCulture));
        }

        long first = ticks[0];
        long last = ticks[Batches - 1];

        Console.WriteLine();
        Console.WriteLine("Первая партия: " + first);
        Console.WriteLine("Последняя партия: " + last);
        Console.WriteLine("Отношение: " + (last == 0 ? "деление на ноль" : ((double)first / last).ToString("F2", System.Globalization.CultureInfo.InvariantCulture)));

        return 0;
    }

    /// <summary>Сколько партий печатается.</summary>
    private const int Batches = 40;

    /// <summary>Сколько вызовов в партии.</summary>
    private const int Batch = 200;

    /// <summary>Значение переменной окружения или пометка, что она не задана.</summary>
    private static string Setting(string name) => Environment.GetEnvironmentVariable(name) ?? "не задано";
}
