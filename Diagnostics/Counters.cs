using JitFoldProof.Types;

namespace JitFoldProof.Diagnostics;

/// <summary>
/// Счётчик обращений к полезной работе. Показывает, что дело не в работе
/// под проверками: если число обращений у всех вариантов одинаково, разница
/// во времени приходится на сами проверки типа.
/// </summary>
internal static class Counters
{
    /// <summary>Выводит счётчик по каждому варианту раздела 3.</summary>
    internal static int Run()
    {
        Console.WriteLine("Обращения к полезной работе, по " + Count + " вызовов на вариант");
        Console.WriteLine();

        long numbers = Measure(static () =>
        {
            for (int i = 0; i < Count; i++)
            {
                _ = Subjects.Ladder(i);
            }
        });

        Unlisted[] unlisted = Payloads.Unlisted(Count);
        long missing = Measure(() =>
        {
            for (int i = 0; i < Count; i++)
            {
                _ = Subjects.Ladder(unlisted[i]);
            }
        });

        string[] words = Payloads.Words(Count);
        long text = Measure(() =>
        {
            for (int i = 0; i < Count; i++)
            {
                _ = Subjects.Ladder(words[i]);
            }
        });

        object[] objects = new object[Count];
        for (int i = 0; i < Count; i++)
        {
            objects[i] = words[i];
        }

        long boxed = Measure(() =>
        {
            for (int i = 0; i < Count; i++)
            {
                _ = Subjects.Ladder(objects[i]);
            }
        });

        Print("Ladder<int>", numbers);
        Print("Ladder<Unlisted>", missing);

        Print("Ladder<string>", text);
        Print("Ladder<object>", boxed);

        bool ok = numbers == Count && missing == Count && text == Count && boxed == Count;

        Console.WriteLine();
        Console.WriteLine(ok
            ? "Число обращений у всех вариантов одинаково"
            : "ЧИСЛО ОБРАЩЕНИЙ РАЗЛИЧАЕТСЯ, сравнивать варианты нельзя");

        return ok ? 0 : 1;
    }

    /// <summary>Сколько раз вызывается цепочка проверок в каждом варианте.</summary>
    private const int Count = 100_000;

    /// <summary>Счётчик до и после одного варианта.</summary>
    private static long Measure(Action body)
    {
        Subjects.ResetWorkCalls();
        body();

        return Subjects.WorkCalls;
    }

    /// <summary>Одна строка отчёта.</summary>
    private static void Print(string name, long calls) => Console.WriteLine("  " + name.PadRight(18) + calls);
}
