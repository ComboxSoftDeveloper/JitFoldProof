namespace JitFoldProof.Types;

/// <summary>
/// Значимый тип без ссылок. Очистка списка таких значений рантайму не нужна.
/// </summary>
internal struct PointValue
{
    internal int X;
    internal int Y;
}

/// <summary>
/// Значимый тип со ссылкой внутри. Внешне такой же struct, но очищать список
/// таких значений рантайм обязан: иначе ссылка удержит объект от сборки.
/// Пара с <see cref="PointValue"/> закрывает возражение
/// «дело в том, что один тип ссылочный, а другой нет».
/// </summary>
internal struct PairValue
{
    internal int Key;
    internal string? Name;
}

/// <summary>
/// Ссылочный тип, которого нет в проверках раздела 3. Нужен как случай,
/// когда ни одна проверка не совпала и выполнились все двенадцать.
/// </summary>
internal sealed class Unlisted;
