namespace JitFoldProof.Types;

/// <summary>
/// Наборы данных. Один набор на все замеры и все отчёты: иначе числа
/// в разных отчётах будут получены на разных входах и сравнивать их нельзя.
/// </summary>
internal static class Payloads
{
    /// <summary>Слово, с которым сравниваются строки во всех замерах раздела 2.</summary>
    internal const string Marker = "content-length";

    /// <summary>Три размера строковых наборов.</summary>
    internal static readonly int[] Sizes = [64, 1024, 16384];

    /// <summary>
    /// Строки, совпадающие со вторым операндом целиком. Худший случай: сравнение
    /// дойдёт до последнего символа.
    /// </summary>
    internal static string[] Matching(int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = Opaque(Marker);
        }

        return result;
    }

    /// <summary>
    /// Строки той же длины с тем же началом, но другим концом.
    /// Закрывает возражение «ты подобрал данные, у тебя всё расходится с первого символа».
    /// </summary>
    internal static string[] SharedPrefix(int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = Opaque("content-lengtX");
        }

        return result;
    }

    /// <summary>Строки, расходящиеся с первого символа.</summary>
    internal static string[] Different(int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = Opaque("Xontent-length");
        }

        return result;
    }

    /// <summary>Пустые строки, собранные в рантайме.</summary>
    internal static string[] Empty(int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = Opaque(string.Empty);
        }

        return result;
    }

    /// <summary>Числа для замеров вопросов 3 и 4.</summary>
    internal static int[] Numbers(int count)
    {
        int[] result = new int[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = i;
        }

        return result;
    }

    /// <summary>
    /// Значения ссылочного типа, которого нет в проверках раздела 3.
    /// На них выполняются все двенадцать проверок.
    /// </summary>
    internal static Unlisted[] Unlisted(int count)
    {
        Unlisted[] result = new Unlisted[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = new Unlisted();
        }

        return result;
    }

    /// <summary>Ссылочные значения того же количества — для тех же замеров.</summary>
    internal static string[] Words(int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = Opaque("w" + i.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        return result;
    }

    /// <summary>
    /// Копия строки, о содержимом которой JIT при компиляции ничего не знает.
    /// Литерал он вычислил бы, и оба метода пары скомпилировались бы в одно.
    ///
    /// Для пустой строки копии не получится: экземпляр нулевой длины в рантайме
    /// один на весь процесс, любая попытка создать новый возвращает его же.
    /// Поэтому строка для сравнения передаётся параметром, а не полем:
    /// параметр JIT не вычислит ни при каких условиях.
    /// </summary>
    internal static string Opaque(string value) => new(value.ToCharArray());
}
