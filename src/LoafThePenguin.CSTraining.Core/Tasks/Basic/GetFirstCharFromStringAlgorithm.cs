using LoafThePenguin.Helpers;

namespace LoafThePenguin.CSTraining.Core.Tasks.Basic;

/// <summary>
/// Алгоритм получения первой буквы строки.
/// </summary>
/// <exception cref="NullReferenceException"/>
public sealed class GetFirstCharFromStringAlgorithm : IAlgorithm<string, char?>
{
    private readonly GetCharFromStringAlgorithm _algorithm;

    /// <summary>
    /// Создаёт экземпляр алгоритма получения первой буквы строки.
    /// </summary>
    public GetFirstCharFromStringAlgorithm()
    {
        _algorithm = new GetCharFromStringAlgorithm();
    }

    /// <summary>
    /// <inheritdoc/>
    /// Возвращает первую букву строки или <see langword="null"/>, 
    /// если длина <paramref name="input"/> равна 0.
    /// </summary>
    /// <param name="input">
    /// <inheritdoc/>
    /// </param>
    /// <returns>
    /// Первая буква строки или <see langword="null"/>, 
    /// если длина <paramref name="input"/> равна 0.
    /// </returns>
    /// <exception cref="NullReferenceException">
    /// Выбрасывается, когда <paramref name="input"/> является <see langword="null"/>.
    /// </exception>
    public char? Run(string input)
    {
        _ = ThrowHelper.ThrowIfNull(input);

        return _algorithm.Run(input, 0);
    }
}
