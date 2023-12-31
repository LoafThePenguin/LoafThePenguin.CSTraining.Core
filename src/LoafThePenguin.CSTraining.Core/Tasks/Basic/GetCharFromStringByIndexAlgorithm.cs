using LoafThePenguin.Helpers;

namespace LoafThePenguin.CSTraining.Core.Tasks.Basic;

/// <summary>
/// Алгоритм получения буквы строки по индексу.
/// </summary>
public sealed class GetCharFromStringByIndexAlgorithm : IAlgorithm<string, int, char?>
{
    /// <summary>
    /// Создаёт экземпляр алгоритма получения буквы строки по индексу.
    /// </summary>
    public GetCharFromStringByIndexAlgorithm()
    {

    }

    /// <summary>
    /// <inheritdoc/>
    /// Возвращает символ строки с индексом <paramref name="index"/> или <see langword="null"/>, если длина <paramref name="input"/> меньше либо равна <paramref name="index"/>.
    /// </summary>
    /// <param name="input">
    /// Строка.
    /// </param>
    /// <param name="index">
    /// Индекс.
    /// </param>
    /// <returns>
    /// Первая буква строки или <see langword="null"/>, 
    /// если длина <paramref name="input"/> меньше либо равна <paramref name="index"/>.
    /// </returns>
    /// <exception cref="NullReferenceException">
    /// Выбрасывается, когда <paramref name="input"/> является <see langword="null"/>.
    /// </exception>
    /// <exception cref="IndexOutOfRangeException">
    /// Выбрасывается, когда <paramref name="index"/> меньше 0.
    /// </exception>
    public char? Run(string input, int index)
    {
        _ = ThrowHelper.ThrowIfArgumentNull(input);
        ThrowHelper.ThrowIfIndexLowerZero(index);

        if (input.Length <= index)
        {
            return null;
        }

        return input[index];
    }
}
