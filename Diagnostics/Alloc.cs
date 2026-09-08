namespace JitFoldProof.Diagnostics;

/// <summary>
/// Выделение памяти, посчитанное без BenchmarkDotNet. Закрывает возражение
/// «это артефакт BenchmarkDotNet»: тот же вывод получается счётчиком
/// рантайма в обычном цикле.
///
/// Отчёт заодно проверяет сам себя. Если прогон идёт с отключённым
/// размещением на стеке, у методов «объект остаётся в методе» и «ссылка
/// записывается в поле» числа совпадут. Если совпали и без отключения —
/// значит на этом рантайме размещения на стеке нет, и так и надо написать,
/// а не подгонять объяснение.
/// </summary>
internal static class Alloc
{
    /// <summary>Выводит выделенные байты по каждому методу раздела 1.</summary>
    internal static int Run()
    {
        Console.WriteLine("Рантайм: " + Environment.Version);
        Console.WriteLine("Размещение на стеке: " + Setting("DOTNET_JitObjectStackAllocation"));
        Console.WriteLine("Многоуровневая компиляция: " + Setting("DOTNET_TieredCompilation"));
        Console.WriteLine("Динамический профиль: " + Setting("DOTNET_TieredPGO"));
        Console.WriteLine();
        Console.WriteLine("Выделено байт на " + Count + " вызовов:");
        Console.WriteLine();

        long boxStays = Measure(static seed => Subjects.BoxStays(seed));
        
        long boxEscapes = Measure(static seed => Subjects.BoxEscapes(seed));
        long arrayStays = Measure(static seed => Subjects.ArrayStays(seed));
        
        long arrayEscapes = Measure(static seed => Subjects.ArrayEscapes(seed));
        long onStack = Measure(static seed => Subjects.ArrayOnStack(seed));

        Print("BoxStays", boxStays);
        
        Print("BoxEscapes", boxEscapes);
        Print("ArrayStays", arrayStays);
        
        Print("ArrayEscapes", arrayEscapes);
        Print("ArrayOnStack", onStack);

        Console.WriteLine();
        Console.WriteLine("Объект, уходящий в поле, выделяет больше остающегося: " + Answer(boxEscapes > boxStays));
        Console.WriteLine("Массив, уходящий в поле, выделяет больше остающегося:  " + Answer(arrayEscapes > arrayStays));

        return 0;
    }

    /// <summary>Сколько вызовов приходится на один метод.</summary>
    private const int Count = 1_000_000;

    /// <summary>
    /// Прогрев и замер. Прогрев нужен, чтобы метод успел попасть на второй
    /// уровень компиляции: на первом размещения на стеке нет, и без прогрева
    /// отчёт показал бы выделения у всех методов.
    /// </summary>
    private static long Measure(Func<int, int> body)
    {
        for (int i = 0; i < Count; i++)
        {
            _ = body(i);
        }

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long before = GC.GetAllocatedBytesForCurrentThread();
        for (int i = 0; i < Count; i++)
        {
            _ = body(i);
        }

        return GC.GetAllocatedBytesForCurrentThread() - before;
    }

    /// <summary>Одна строка отчёта.</summary>
    private static void Print(string name, long bytes) => Console.WriteLine("  " + name.PadRight(16) + bytes.ToString("N0", System.Globalization.CultureInfo.InvariantCulture));

    /// <summary>Значение переменной окружения или пометка, что она не задана.</summary>
    private static string Setting(string name) => Environment.GetEnvironmentVariable(name) ?? "не задано";

    /// <summary>Ответ да или нет словом.</summary>
    private static string Answer(bool value) => value ? "да" : "нет";
}
