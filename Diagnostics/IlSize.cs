using System.Reflection;

namespace JitFoldProof.Diagnostics;

/// <summary>
/// Размер тела метода в байтах промежуточного языка. Нужен вопросам 1 и 3:
/// утверждение «этот код исчезает» проверяется тем, что в исходнике он есть,
/// а в машинном коде его нет. Размер тела показывает первую половину — код
/// действительно написан и компилятор его не выбросил.
/// </summary>
internal static class IlSize
{
    /// <summary>Печатает размер тела каждого измеряемого способа.</summary>
    internal static int Run()
    {
        Console.WriteLine("Размер тела метода в байтах промежуточного языка");
        Console.WriteLine();

        MethodInfo[] methods = typeof(Subjects)
            .GetMethods(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.DeclaredOnly);

        Array.Sort(methods, static (left, right) => string.CompareOrdinal(left.Name, right.Name));

        int printed = 0;
        foreach (MethodInfo method in methods)
        {
            MethodBody? body = method.GetMethodBody();

            byte[]? il = body?.GetILAsByteArray();
            if (il is null)
            {
                continue;
            }

            Console.WriteLine("  " + method.Name.PadRight(20) + il.Length);
            printed++;
        }

        Console.WriteLine();
        Console.WriteLine("Способов прочитано: " + printed);

        return printed > 0 ? 0 : 1;
    }
}
