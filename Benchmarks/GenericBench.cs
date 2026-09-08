using BenchmarkDotNet.Attributes;
using JitFoldProof.Types;

namespace JitFoldProof.Benchmarks;

/// <summary>
/// Раздел 3. Одна и та же цепочка из двенадцати проверок типа, вызванная
/// со значимым типом и со ссылочными. Число обращений к полезной работе
/// у всех вариантов одинаково — это проверяет отчёт counters.
/// </summary>
public class GenericBench
{
    private int[] _numbers = [];
    private string[] _words = [];

    private object[] _objects = [];
    private Unlisted[] _unlisted = [];

    /// <summary>Три размера набора.</summary>
    [ParamsSource(nameof(SizeValues))]
    public int Size { get; set; }

    /// <summary>Размеры общие с остальными замерами.</summary>
    public static IEnumerable<int> SizeValues => Payloads.Sizes;

    /// <summary>Подготовка данных.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _numbers = Payloads.Numbers(Size);
        
        _words = Payloads.Words(Size);
        _unlisted = Payloads.Unlisted(Size);

        _objects = new object[Size];
        for (int i = 0; i < Size; i++)
        {
            _objects[i] = _words[i];
        }
    }

    /// <summary>Значимый тип: вся цепочка удалена, не выполняется ни одна проверка.</summary>
    [Benchmark(Baseline = true)]
    public int Numbers()
    {
        int sum = 0;
        for (int i = 0; i < _numbers.Length; i++)
        {
            sum += Subjects.Ladder(_numbers[i]);
        }

        return sum;
    }

    /// <summary>Ссылочный тип, совпадающий на первой ветке: одна проверка.</summary>
    [Benchmark]
    public int Words()
    {
        int sum = 0;
        for (int i = 0; i < _words.Length; i++)
        {
            sum += Subjects.Ladder(_words[i]);
        }

        return sum;
    }

    /// <summary>Ссылочный тип, совпадающий на второй ветке: две проверки.</summary>
    [Benchmark]
    public int Objects()
    {
        int sum = 0;
        for (int i = 0; i < _objects.Length; i++)
        {
            sum += Subjects.Ladder(_objects[i]);
        }

        return sum;
    }

    /// <summary>Ссылочный тип, которого в проверках нет: выполняются все двенадцать.</summary>
    [Benchmark]
    public int Unlisted()
    {
        int sum = 0;
        for (int i = 0; i < _unlisted.Length; i++)
        {
            sum += Subjects.Ladder(_unlisted[i]);
        }

        return sum;
    }
}
