using LoafThePenguin.Helpers;

namespace LoafThePenguin.CSTraining.Core.Tasks.Basic;

/// <summary>
/// Алгоритм, убирающий пробелы с начала и с конца строки.
/// </summary>
/// <exception cref="NullReferenceException"/>
public sealed class TrimWhitespacesAlgorithm : IAlgorithm<string, string>
{
    /// <summary>
    /// Создаёт экземпляр Алгоритма, убирающего пробелы с начала и с конца строки.
    /// </summary>
    public TrimWhitespacesAlgorithm()
    {
        
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="input">
    /// <inheritdoc/>
    /// </param>
    /// <returns>Строка без пробелов в конце и в начале.</returns>
    /// <exception cref="NullReferenceException">
    /// Выбрасывается, когда <paramref name="input"/> является <see langword="null"/>.
    /// </exception>
    public string Run(string input)
    {
        _ = ThrowHelper.ThrowIfArgumentNull(input);

        return input.Trim();
    }
}
