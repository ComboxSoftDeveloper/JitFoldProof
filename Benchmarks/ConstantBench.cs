using BenchmarkDotNet.Attributes;
using JitFoldProof.Types;

namespace JitFoldProof.Benchmarks;

/// <summary>
/// Раздел 2. Одно и то же сравнение: справа литерал или строка из параметра.
/// Данные у обоих методов одни и те же.
/// </summary>
public class ConstantBench
{
    private string[] _data = [];

    /// <summary>Строка для сравнения. Заполняется в GlobalSetup, поэтому JIT её при компиляции не знает.</summary>
    private string _marker = string.Empty;

    /// <summary>Пустая строка, по той же причине.</summary>
    private string _empty = string.Empty;

    /// <summary>Три размера набора.</summary>
    [ParamsSource(nameof(SizeValues))]
    public int Size { get; set; }

    /// <summary>
    /// Четыре набора: совпадающие строки, строки с общим началом,
    /// расходящиеся с первого символа и пустые.
    /// </summary>
    [Params("match", "prefix", "differ", "empty")]
    public string Kind { get; set; } = "match";

    /// <summary>Размеры берутся из общего списка, чтобы совпадать с отчётами.</summary>
    public static IEnumerable<int> SizeValues => Payloads.Sizes;

    /// <summary>Подготовка вынесена сюда: в теле замера её быть не должно.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _marker = Payloads.Opaque(Payloads.Marker);
        _empty = Payloads.Opaque(string.Empty);

        _data = Kind switch
        {
            "match" => Payloads.Matching(Size),
            "prefix" => Payloads.SharedPrefix(Size),
            "differ" => Payloads.Different(Size),
            _ => Payloads.Empty(Size),
        };
    }

    /// <summary>Сравнение с литералом.</summary>
    [Benchmark(Baseline = true)]
    public int EqualsLiteral()
    {
        int hits = 0;
        for (int i = 0; i < _data.Length; i++)
        {
            if (Subjects.EqualsLiteral(_data[i]))
            {
                hits++;
            }
        }

        return hits;
    }

    /// <summary>Сравнение с переменной.</summary>
    [Benchmark]
    public int EqualsOpaque()
    {
        int hits = 0;
        for (int i = 0; i < _data.Length; i++)
        {
            if (Subjects.EqualsOpaque(_data[i], _marker))
            {
                hits++;
            }
        }

        return hits;
    }

    /// <summary>Проверка на пустоту сравнением с пустым литералом.</summary>
    [Benchmark]
    public int EmptyByLiteral()
    {
        int hits = 0;
        for (int i = 0; i < _data.Length; i++)
        {
            if (Subjects.EmptyByLiteral(_data[i]))
            {
                hits++;
            }
        }

        return hits;
    }

    /// <summary>То же сравнением с переменной.</summary>
    [Benchmark]
    public int EmptyByOpaque()
    {
        int hits = 0;
        for (int i = 0; i < _data.Length; i++)
        {
            if (Subjects.EmptyByOpaque(_data[i], _empty))
            {
                hits++;
            }
        }

        return hits;
    }

    /// <summary>То же через длину.</summary>
    [Benchmark]
    public int EmptyByLength()
    {
        int hits = 0;
        for (int i = 0; i < _data.Length; i++)
        {
            if (Subjects.EmptyByLength(_data[i]))
            {
                hits++;
            }
        }

        return hits;
    }

    /// <summary>Первый символ через перегрузку с символом.</summary>
    [Benchmark]
    public int StartsWithChar()
    {
        int hits = 0;
        for (int i = 0; i < _data.Length; i++)
        {
            if (Subjects.StartsWithChar(_data[i]))
            {
                hits++;
            }
        }

        return hits;
    }

    /// <summary>Первый символ через перегрузку со строкой.</summary>
    [Benchmark]
    public int StartsWithText()
    {
        int hits = 0;
        for (int i = 0; i < _data.Length; i++)
        {
            if (Subjects.StartsWithText(_data[i]))
            {
                hits++;
            }
        }

        return hits;
    }
}
