using BenchmarkDotNet.Attributes;
using JitFoldProof.Types;

namespace JitFoldProof.Benchmarks;

/// <summary>
/// Раздел 5. Сумма с проверкой поддержки векторов внутри метода и без неё.
/// Если JIT действительно подставляет в проверку константу, она ничего
/// не стоит, и разница между методами объясняется только векторным циклом.
/// </summary>
public class TierBench
{
    private int[] _data = [];

    /// <summary>Три размера.</summary>
    [ParamsSource(nameof(SizeValues))]
    public int Size { get; set; }

    /// <summary>Размеры общие с остальными замерами.</summary>
    public static IEnumerable<int> SizeValues => Payloads.Sizes;

    /// <summary>Подготовка данных.</summary>
    [GlobalSetup]
    public void Setup() => _data = Payloads.Numbers(Size);

    /// <summary>Сумма с проверкой возможностей процессора.</summary>
    [Benchmark(Baseline = true)]
    public int Guarded() => Subjects.SumGuarded(_data);

    /// <summary>Сумма без векторного пути.</summary>
    [Benchmark]
    public int Scalar() => Subjects.SumScalar(_data);
}
