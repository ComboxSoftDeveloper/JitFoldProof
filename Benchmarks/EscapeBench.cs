using BenchmarkDotNet.Attributes;

namespace JitFoldProof.Benchmarks;

/// <summary>
/// Раздел 1. Один и тот же new: в первом методе объект не выходит за пределы
/// вызова, во втором ссылка записывается в статическое поле. Смотреть надо
/// на столбцы Code Size и Allocated, а не на время.
/// </summary>
public class EscapeBench
{
    private int _seed;

    /// <summary>Затравка берётся в рантайме, чтобы результат нельзя было вычислить при компиляции.</summary>
    [GlobalSetup]
    public void Setup() => _seed = Environment.TickCount;

    /// <summary>Объект не выходит за пределы вызова.</summary>
    [Benchmark(Baseline = true)]
    public int BoxStays() => Subjects.BoxStays(_seed);

    /// <summary>Ссылка на объект записывается в статическое поле.</summary>
    [Benchmark]
    public int BoxEscapes() => Subjects.BoxEscapes(_seed);

    /// <summary>Массив не выходит за пределы вызова.</summary>
    [Benchmark]
    public int ArrayStays() => Subjects.ArrayStays(_seed);

    /// <summary>Массив уходит в поле.</summary>
    [Benchmark]
    public int ArrayEscapes() => Subjects.ArrayEscapes(_seed);

    /// <summary>Буфер из стека: опора, у которой выделения нет наверняка.</summary>
    [Benchmark]
    public int ArrayOnStack() => Subjects.ArrayOnStack(_seed);
}
