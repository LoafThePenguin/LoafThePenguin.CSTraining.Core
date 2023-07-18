using System.Numerics;
using LoafThePenguin.Helpers;

namespace LoafThePenguin.CSTraining.Core.Tasks.Basic;

/// <summary>
/// Алгоритм получения первой буквы строки.
/// </summary>
public sealed class GetFirstCharFromStringAlgorithm : IAlgorithm<string, char?>
{
    /// <summary>
    /// Создаёт экземпляр алгоритм получения первой буквы строки.
    /// </summary>
    public GetFirstCharFromStringAlgorithm()
    {

    }

    /// <summary>
    /// <inheritdoc/>
    /// Возвращает первую букву строки или <see langword="null"/>, если длина <paramref name="input"/> равна 0.
    /// </summary>
    /// <param name="input">
    /// <inheritdoc/>
    /// </param>
    /// <returns>Первая буква строки или <see langword="null"/>, если длина <paramref name="input"/> равна 0.</returns>
    public char? Run(string input)
    {
        _ = ThrowHelper.ThrowIfNull(input);

        if (input.Length == 0)
        {
            return null;
        }

        return input[0];
    }
}
