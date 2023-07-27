using LoafThePenguin.Helpers;

namespace LoafThePenguin.CSTraining.Core.Tasks.Basic;

/// <summary>
/// Алгоритм получения буквы строки по порядковому номеру.
/// </summary>
public sealed class GetCharFromStringBySequenceAlgorithm : IAlgorithm<string, int, char?>
{
    private const string IOE_MESSAGE_SEQ_EQUALS_ZERO = "Порядковый номер не может быть равен 0";
    private const string IOE_MESSAGE_SEQ_LOWER_ZERO = "Порядковый номер не может быть меньше 0";

    private readonly GetCharFromStringByIndexAlgorithm _getCharFromStringByIndexAlgorithm;

    /// <summary>
    /// Создаёт экземпляр алгоритма получения буквы строки по порядковому номеру.
    /// </summary>
    public GetCharFromStringBySequenceAlgorithm() => _getCharFromStringByIndexAlgorithm = new GetCharFromStringByIndexAlgorithm();

    /// <summary>
    /// <inheritdoc/>
    /// Возвращает символ строки с порядковым номером <paramref name="seqNum"/> или <see langword="null"/>, 
    /// если длина <paramref name="input"/> меньше <paramref name="seqNum"/>.
    /// </summary>
    /// <param name="input">
    /// Строка.
    /// </param>
    /// <param name="seqNum">
    /// Порядковый номер.
    /// </param>
    /// <returns>
    /// Первая буква строки или <see langword="null"/>, 
    /// если длина <paramref name="input"/> меньше <paramref name="seqNum"/>.
    /// </returns>
    /// <exception cref="NullReferenceException">
    /// Выбрасывается, когда <paramref name="input"/> является <see langword="null"/>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Выбрасывается, когда <paramref name="seqNum"/> является 0.
    /// </exception>
    public char? Run(string input, int seqNum)
    {
        _ = ThrowHelper.ThrowIfArgumentNull(input);
        if (seqNum == 0)
        {
            ThrowHelper.Throw<InvalidOperationException>(IOE_MESSAGE_SEQ_EQUALS_ZERO);
        }

        if (seqNum < 0)
        {
            ThrowHelper.Throw<InvalidOperationException>(IOE_MESSAGE_SEQ_LOWER_ZERO);
        }

        return _getCharFromStringByIndexAlgorithm.Run(input, seqNum - 1);
    }
}
