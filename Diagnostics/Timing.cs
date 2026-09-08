using System.Diagnostics;
using JitFoldProof.Types;

namespace JitFoldProof.Diagnostics;

/// <summary>
/// Тот же замер на секундомере из отдельного процесса. Закрывает возражение
/// «это артефакт BenchmarkDotNet»: три прохода, печатается разброс.
/// </summary>
internal static class Timing
{
    /// <summary>Печатает три прохода по каждой паре способов.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine("Проходов: " + Passes + ", вызовов в проходе: " + Count);
        Console.WriteLine();

        string[] matching = Payloads.Matching(Count);
        int[] numbers = Payloads.Numbers(Count);

        Unlisted[] unlisted = Payloads.Unlisted(Count);
        string marker = Payloads.Opaque(Payloads.Marker);

        Row("EqualsLiteral", () =>
        {
            int hits = 0;
            for (int i = 0; i < matching.Length; i++)
            {
                if (Subjects.EqualsLiteral(matching[i]))
                {
                    hits++;
                }
            }

            return hits;
        });

        Row("EqualsOpaque", () =>
        {
            int hits = 0;
            for (int i = 0; i < matching.Length; i++)
            {
                if (Subjects.EqualsOpaque(matching[i], marker))
                {
                    hits++;
                }
            }

            return hits;
        });

        Row("Ladder<int>", () =>
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Subjects.Ladder(numbers[i]);
            }

            return sum;
        });

        Row("Ladder<Unlisted>", () =>
        {
            int sum = 0;
            for (int i = 0; i < unlisted.Length; i++)
            {
                sum += Subjects.Ladder(unlisted[i]);
            }

            return sum;
        });

        Row("BoxStays", () =>
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += Subjects.BoxStays(i);
            }

            return sum;
        });

        Row("BoxEscapes", () =>
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += Subjects.BoxEscapes(i);
            }

            return sum;
        });

        return 0;
    }

    /// <summary>Сколько проходов на способ.</summary>
    private const int Passes = 3;

    /// <summary>Сколько вызовов в проходе.</summary>
    private const int Count = 100_000;

    /// <summary>Один способ: прогрев, три прохода, разброс.</summary>
    private static void Row(string name, Func<int> body)
    {
        // Прогрев: без него первый проход померил бы компиляцию.
        for (int i = 0; i < 5; i++)
        {
            _ = body();
        }

        double[] times = new double[Passes];

        Stopwatch watch = new();
        for (int pass = 0; pass < Passes; pass++)
        {
            watch.Restart();

            int result = body();
            watch.Stop();
            
            times[pass] = watch.Elapsed.TotalMilliseconds;

            if (result == int.MinValue)
            {
                Console.WriteLine("недостижимо");
            }
        }

        double min = times[0];
        double max = times[0];

        double sum = 0;
        foreach (double value in times)
        {
            if (value < min)
            {
                min = value;
            }

            if (value > max)
            {
                max = value;
            }

            sum += value;
        }

        double mean = sum / Passes;
        double spread = mean == 0 ? 0 : (max - min) / mean * 100;

        Console.WriteLine("  " + name.PadRight(18) +
            "среднее " + mean.ToString("F3", System.Globalization.CultureInfo.InvariantCulture) + " мс" +
            ", разброс " + spread.ToString("F1", System.Globalization.CultureInfo.InvariantCulture) + " %");
    }
}
