using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using JitFoldProof.Types;

namespace JitFoldProof.Benchmarks;

/// <summary>
/// Раздел 4. Очистка четырёх списков: числа, ссылки, значимый тип без ссылок
/// и значимый тип со ссылкой внутри. Проверка «тип содержит ссылки» стоит
/// в исходнике List, но в машинный код не попадает — попадает только один
/// из её исходов.
///
/// Замер стирает данные, поэтому он идёт по одному вызову на измерение:
/// RunOncePerIteration ставит число вызовов и развёртку в единицу,
/// а восстановление стоит в IterationSetup. Восстановление не выделяет
/// память: вместимость списка остаётся прежней, меняется только счётчик
/// элементов.
/// </summary>
[RunOncePerIteration]
public class ClearBench
{
    private readonly List<int> _numbers = [];
    private readonly List<string?> _words = [];

    private readonly List<PointValue> _points = [];
    private readonly List<PairValue> _pairs = [];

    /// <summary>Три размера.</summary>
    [Params(10_000, 100_000, 1_000_000)]
    public int Size { get; set; }

    /// <summary>Разовое заполнение всех четырёх списков.</summary>
    [GlobalSetup]
    public void Setup()
    {
        _numbers.Clear();
        _words.Clear();

        _points.Clear();
        _pairs.Clear();

        _numbers.Capacity = Size;
        _words.Capacity = Size;

        _points.Capacity = Size;
        _pairs.Capacity = Size;

        for (int i = 0; i < Size; i++)
        {
            _numbers.Add(i);
            _words.Add(Payloads.Opaque("w"));

            _points.Add(new PointValue
            {
                X = i,
                Y = i
            });

            _pairs.Add(new PairValue
            {
                Key = i,
                Name = Payloads.Opaque("w")
            });
        }
    }

    /// <summary>
    /// Восстановление между вызовами. SetCount возвращает счётчик элементов
    /// на место, не трогая массив: вместимость уже выделена, нового массива
    /// не создаётся, и столбец Allocated меряет очистку, а не подготовку.
    /// </summary>
    [IterationSetup]
    public void Restore()
    {
        CollectionsMarshal.SetCount(_numbers, Size);
        CollectionsMarshal.SetCount(_words, Size);

        CollectionsMarshal.SetCount(_points, Size);
        CollectionsMarshal.SetCount(_pairs, Size);
    }

    /// <summary>Числа: очищать нечего, рантайм только сбрасывает счётчик.</summary>
    [Benchmark(Baseline = true)]
    public void Numbers() => Subjects.ClearNumbers(_numbers);

    /// <summary>Ссылки: массив обнуляется целиком.</summary>
    [Benchmark]
    public void Words() => Subjects.ClearWords(_words);

    /// <summary>Значимый тип без ссылок: ведёт себя как числа.</summary>
    [Benchmark]
    public void Points() => Subjects.ClearPoints(_points);

    /// <summary>Значимый тип со ссылкой внутри: ведёт себя как ссылки.</summary>
    [Benchmark]
    public void Pairs() => Subjects.ClearPairs(_pairs);
}
