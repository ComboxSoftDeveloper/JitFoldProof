using System.Runtime.InteropServices;
using JitFoldProof.Types;

namespace JitFoldProof.Diagnostics;

/// <summary>
/// Сверка. Проверяет, что все варианты каждого вопроса возвращают то, что
/// должны, и роняет прогон при расхождении. Без неё сравнение способов
/// не имеет смысла: быстрее может оказаться тот, кто считает не то.
/// </summary>
internal static class Checks
{
    /// <summary>Код возврата: 0 — всё сошлось, 1 — есть расхождение.</summary>
    internal static int Run()
    {
        bool ok = true;
        ok &= Question1();
        
        ok &= Question2();
        ok &= Question3();
        
        ok &= Question4();
        ok &= Question5();

        Console.WriteLine();
        Console.WriteLine(ok ? "СВЕРКА ПРОЙДЕНА" : "СВЕРКА НЕ ПРОЙДЕНА");
        
        return ok ? 0 : 1;
    }

    /// <summary>Раздел 2: сравнение с литералом и с параметром дают один ответ.</summary>
    private static bool Question1()
    {
        Console.WriteLine("Раздел 2. Сравнение с литералом");
        
        bool ok = true;

        string marker = Payloads.Opaque(Payloads.Marker);
        string empty = Payloads.Opaque(string.Empty);

        foreach (string value in Values())
        {
            ok &= Same("EqualsLiteral / EqualsOpaque", value, Subjects.EqualsLiteral(value), Subjects.EqualsOpaque(value, marker));
            ok &= Same("EmptyByLiteral / EmptyByOpaque", value, Subjects.EmptyByLiteral(value), Subjects.EmptyByOpaque(value, empty));

            ok &= Same("EmptyByLiteral / EmptyByLength", value, Subjects.EmptyByLiteral(value), Subjects.EmptyByLength(value));
            ok &= Same("StartsWithChar / StartsWithText", value, Subjects.StartsWithChar(value), Subjects.StartsWithText(value));
        }

        return ok;
    }

    /// <summary>
    /// Раздел 4: у всех четырёх списков после очистки нулевой счётчик,
    /// но массив обнуляется только там, где значения содержат ссылки.
    /// Это и есть проверяемое различие, и видно оно по памяти, а не по времени.
    /// </summary>
    private static bool Question2()
    {
        Console.WriteLine();
        Console.WriteLine("Раздел 4. Очистка списка");

        const int size = 16;
        bool ok = true;

        List<string?> words = [];
        for (int i = 0; i < size; i++)
        {
            words.Add(Payloads.Opaque("w"));
        }

        Subjects.ClearWords(words);
        CollectionsMarshal.SetCount(words, size);

        int survivors = 0;
        foreach (string? item in CollectionsMarshal.AsSpan(words))
        {
            if (item is not null)
            {
                survivors++;
            }
        }

        ok &= Report("список ссылок: ссылок в массиве после очистки", survivors, 0);

        List<PairValue> pairs = [];
        for (int i = 0; i < size; i++)
        {
            pairs.Add(new PairValue
            {
                Key = i,
                Name = Payloads.Opaque("w")
            });
        }

        Subjects.ClearPairs(pairs);
        CollectionsMarshal.SetCount(pairs, size);

        int pairSurvivors = 0;
        foreach (PairValue item in CollectionsMarshal.AsSpan(pairs))
        {
            if (item.Name is not null)
            {
                pairSurvivors++;
            }
        }

        ok &= Report("значимый тип со ссылкой: ссылок после очистки", pairSurvivors, 0);

        List<int> numbers = [];
        for (int i = 1; i <= size; i++)
        {
            numbers.Add(i);
        }

        Subjects.ClearNumbers(numbers);
        CollectionsMarshal.SetCount(numbers, size);

        int kept = 0;
        foreach (int item in CollectionsMarshal.AsSpan(numbers))
        {
            if (item != 0)
            {
                kept++;
            }
        }

        ok &= Report("список чисел: значений в массиве после очистки", kept, size);

        List<PointValue> points = [];
        for (int i = 1; i <= size; i++)
        {
            points.Add(new PointValue
            {
                X = i,
                Y = i
            });
        }

        Subjects.ClearPoints(points);
        CollectionsMarshal.SetCount(points, size);

        int keptPoints = 0;
        foreach (PointValue item in CollectionsMarshal.AsSpan(points))
        {
            if (item.X != 0)
            {
                keptPoints++;
            }
        }

        ok &= Report("значимый тип без ссылок: значений после очистки", keptPoints, size);

        return ok;
    }

    /// <summary>Раздел 3: цепочка проверок возвращает код, соответствующий типу.</summary>
    private static bool Question3()
    {
        Console.WriteLine();
        Console.WriteLine("Раздел 3. Двенадцать проверок типа");

        bool ok = true;
        ok &= Report("Ladder<int>", Subjects.Ladder(1), 13);
        
        ok &= Report("Ladder<double>", Subjects.Ladder(1d), 13);
        ok &= Report("Ladder<Unlisted>", Subjects.Ladder(new Unlisted()), 13);
        
        ok &= Report("Ladder<string>", Subjects.Ladder("w"), 1);
        ok &= Report("Ladder<object>", Subjects.Ladder(new object()), 2);
        
        return ok;
    }

    /// <summary>Раздел 5: обе суммы дают одно число на всех размерах.</summary>
    private static bool Question4()
    {
        Console.WriteLine();
        Console.WriteLine("Раздел 5. Проверка поддержки векторов");

        bool ok = true;
        foreach (int size in Payloads.Sizes)
        {
            int[] data = Payloads.Numbers(size);
            ok &= Report("сумма на " + size.ToString(System.Globalization.CultureInfo.InvariantCulture), Subjects.SumGuarded(data), Subjects.SumScalar(data));
        }

        return ok;
    }

    /// <summary>Раздел 1: все пять методов считают одно и то же.</summary>
    private static bool Question5()
    {
        Console.WriteLine();
        Console.WriteLine("Раздел 1. Escape-анализ");

        const int seed = 41;
        bool ok = true;

        ok &= Report("BoxStays", Subjects.BoxStays(seed), seed + 1);
        ok &= Report("BoxEscapes", Subjects.BoxEscapes(seed), seed + 1);

        const int expected = seed + seed + 1 + seed + 2 + seed + 3;
        ok &= Report("ArrayStays", Subjects.ArrayStays(seed), expected);
        
        ok &= Report("ArrayEscapes", Subjects.ArrayEscapes(seed), expected);
        ok &= Report("ArrayOnStack", Subjects.ArrayOnStack(seed), expected);

        // Поля читаются: запись в поле, которое никто не читает, JIT вправе
        // удалить, и второй метод пары перестал бы измерять то, что заявлено.
        ok &= Report("последнее записанное в поля", Subjects.LastEscaped, seed + 1 + seed);

        return ok;
    }

    /// <summary>Строки, на которых сверяется раздел 2.</summary>
    private static IEnumerable<string> Values()
    {
        yield return Payloads.Opaque(Payloads.Marker);
        
        yield return Payloads.Opaque("content-lengtX");
        yield return Payloads.Opaque("Xontent-length");
        
        yield return Payloads.Opaque(string.Empty);
        yield return Payloads.Opaque("c");
    }

    /// <summary>Сравнение двух ответов между собой.</summary>
    private static bool Same(string name, string value, bool left, bool right)
    {
        bool ok = left == right;
        Console.WriteLine((ok ? "  ок   " : "  СБОЙ ") + name + " на «" + value + "»: " + left + " и " + right);

        return ok;
    }

    /// <summary>Сравнение ответа с ожидаемым.</summary>
    private static bool Report(string name, int actual, int expected)
    {
        bool ok = actual == expected;
        Console.WriteLine((ok ? "  ок   " : "  СБОЙ ") + name + ": получено " + actual + ", ожидалось " + expected);

        return ok;
    }
}
