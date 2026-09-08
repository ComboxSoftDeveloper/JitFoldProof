using System.Numerics;
using System.Runtime.CompilerServices;
using JitFoldProof.Types;

namespace JitFoldProof;

/// <summary>
/// Все измеряемые методы. У каждого NoInlining: иначе компилятор встроит
/// метод в тело замера и удалит как ненужную работу.
///
/// NoInlining не мешает тому, что проверяется. Вычисление константы и выбор
/// версии метода по типу происходят внутри самого метода, а не на границе
/// с вызывающим.
/// </summary>
internal static class Subjects
{
    /// <summary>Счётчик обращений к полезной работе. Читается отчётом counters.</summary>
    private static long _workCalls;

    /// <summary>Поле, куда записывается ссылка в паре «объект покидает метод».</summary>
    private static StrongBox<int>? _escapedBox;

    /// <summary>То же для массива.</summary>
    private static int[]? _escapedArray;

    // ---------- Раздел 2: сравнение с литералом ----------

    /// <summary>Сравнение с литералом. JIT знает содержимое правой части.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool EqualsLiteral(string value) => value == "content-length";

    /// <summary>
    /// То же сравнение, но строка пришла параметром. Её содержимое JIT
    /// при компиляции не знает, и отдельная реализация для литерала
    /// не подключается.
    ///
    /// Именно параметр, а не статическое поле: поле только для чтения JIT
    /// вправе свернуть в константу после инициализации типа, и тогда оба
    /// метода пары скомпилировались бы в одно и то же.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool EqualsOpaque(string value, string marker) => value == marker;

    /// <summary>Проверка на пустоту через сравнение с пустым литералом.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool EmptyByLiteral(string value) => value == "";

    /// <summary>То же, но пустая строка пришла параметром.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool EmptyByOpaque(string value, string empty) => value == empty;

    /// <summary>То же через длину: запись, не требующая сравнения содержимого.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool EmptyByLength(string value) => value.Length == 0;

    /// <summary>Проверка первого символа перегрузкой с символом.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool StartsWithChar(string value) => value.StartsWith('c');

    /// <summary>То же перегрузкой со строкой из одного символа.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool StartsWithText(string value) => value.StartsWith("c", StringComparison.Ordinal);

    // ---------- Раздел 4: очистка списка ----------

    /// <summary>Очистка списка чисел.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ClearNumbers(List<int> list) => list.Clear();

    /// <summary>Очистка списка ссылок.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ClearWords(List<string?> list) => list.Clear();

    /// <summary>Очистка списка значимых типов без ссылок.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ClearPoints(List<PointValue> list) => list.Clear();

    /// <summary>Очистка списка значимых типов со ссылкой внутри.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ClearPairs(List<PairValue> list) => list.Clear();

    // ---------- Раздел 3: двенадцать проверок типа ----------

    /// <summary>
    /// Двенадцать проверок типа подряд.
    ///
    /// Проверки идут со ссылочными типами, и это не случайность. Общая версия
    /// метода работает только со ссылочными типами, поэтому проверку вида
    /// typeof(T) == typeof(int) JIT вычисляет как false в любой версии, и вся
    /// цепочка удаляется во всех вариантах. Со ссылочными типами вычислить
    /// нечего, и разница между вариантами появляется.
    ///
    /// Для каждого значимого типа JIT компилирует отдельную версию метода
    /// и удаляет всю цепочку. В общей версии выполняется столько проверок,
    /// сколько нужно до совпадения, а если совпадения нет — все двенадцать.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int Ladder<T>(T value)
    {
        if (typeof(T) == typeof(string))
        {
            return Work(1);
        }

        if (typeof(T) == typeof(object))
        {
            return Work(2);
        }

        if (typeof(T) == typeof(Uri))
        {
            return Work(3);
        }

        if (typeof(T) == typeof(Version))
        {
            return Work(4);
        }

        if (typeof(T) == typeof(Exception))
        {
            return Work(5);
        }

        if (typeof(T) == typeof(Type))
        {
            return Work(6);
        }

        if (typeof(T) == typeof(int[]))
        {
            return Work(7);
        }

        if (typeof(T) == typeof(string[]))
        {
            return Work(8);
        }

        if (typeof(T) == typeof(List<int>))
        {
            return Work(9);
        }

        if (typeof(T) == typeof(Dictionary<int, int>))
        {
            return Work(10);
        }

        if (typeof(T) == typeof(Random))
        {
            return Work(11);
        }

        if (typeof(T) == typeof(StringComparer))
        {
            return Work(12);
        }

        return Work(value is null ? 0 : 13);
    }

    /// <summary>
    /// Полезная работа, к которой сводится цепочка проверок. Одна на все
    /// варианты, поэтому число обращений к ней одинаково, и разница во времени
    /// приходится на сами проверки, а не на работу под ними.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int Work(int code)
    {
        _workCalls++;
        return code;
    }

    /// <summary>Текущее число обращений к полезной работе.</summary>
    internal static long WorkCalls => _workCalls;

    /// <summary>Обнуление счётчика перед очередным отчётом.</summary>
    internal static void ResetWorkCalls() => _workCalls = 0;

    // ---------- Раздел 5: проверка поддержки векторов ----------

    /// <summary>
    /// Сумма с проверкой поддержки векторов внутри метода. Выглядит как
    /// условие на каждом вызове, но JIT подставляет константу: поддержка
    /// векторов за время работы процесса не меняется.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int SumGuarded(int[] data)
    {
        int total = 0;
        int index = 0;

        if (Vector.IsHardwareAccelerated && data.Length >= Vector<int>.Count)
        {
            Vector<int> sum = Vector<int>.Zero;
            for (; index <= data.Length - Vector<int>.Count; index += Vector<int>.Count)
            {
                sum += new Vector<int>(data, index);
            }

            total = Vector.Dot(sum, Vector<int>.One);
        }

        for (; index < data.Length; index++)
        {
            total += data[index];
        }

        return total;
    }

    /// <summary>Та же сумма без векторного пути. Опора для сравнения.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int SumScalar(int[] data)
    {
        int total = 0;
        for (int index = 0; index < data.Length; index++)
        {
            total += data[index];
        }

        return total;
    }

    // ---------- Раздел 1: escape-анализ ----------

    /// <summary>
    /// Объект не выходит за пределы вызова. Начиная с .NET 9 JIT удаляет его
    /// целиком: поле объекта становится обычной локальной переменной.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int BoxStays(int seed)
    {
        StrongBox<int> box = new(seed);

        box.Value += 1;
        return box.Value;
    }

    /// <summary>
    /// Тот же объект, но ссылка записывается в статическое поле. Объект
    /// переживает вызов, и выделение в куче остаётся на всех рантаймах.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int BoxEscapes(int seed)
    {
        StrongBox<int> box = new(seed);
        
        box.Value += 1;
        _escapedBox = box;

        return box.Value;
    }

    /// <summary>Массив известной длины, не выходящий за пределы вызова.
    /// Начиная с .NET 10 JIT размещает его на стеке.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int ArrayStays(int seed)
    {
        int[] buffer = new int[4];
        
        buffer[0] = seed;
        buffer[1] = seed + 1;
        
        buffer[2] = seed + 2;
        buffer[3] = seed + 3;
        
        return buffer[0] + buffer[1] + buffer[2] + buffer[3];
    }

    /// <summary>Тот же массив, но ссылка записывается в статическое поле.</summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int ArrayEscapes(int seed)
    {
        int[] buffer = new int[4];
        
        buffer[0] = seed;
        buffer[1] = seed + 1;
        
        buffer[2] = seed + 2;
        buffer[3] = seed + 3;
        
        _escapedArray = buffer;
        
        return buffer[0] + buffer[1] + buffer[2] + buffer[3];
    }

    /// <summary>
    /// Тот же расчёт на буфере из стека. Опорное значение: столько занимает
    /// работа, когда выделения нет заведомо.
    /// </summary>
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static int ArrayOnStack(int seed)
    {
        Span<int> buffer = stackalloc int[4];
        
        buffer[0] = seed;
        buffer[1] = seed + 1;
        
        buffer[2] = seed + 2;
        buffer[3] = seed + 3;
        
        return buffer[0] + buffer[1] + buffer[2] + buffer[3];
    }

    /// <summary>
    /// Последнее, что записано в поля. Читается сверкой: запись в поле,
    /// которое никто не читает, JIT вправе удалить.
    /// </summary>
    internal static int LastEscaped => (_escapedBox?.Value ?? 0) + (_escapedArray is null ? 0 : _escapedArray[0]);
}
