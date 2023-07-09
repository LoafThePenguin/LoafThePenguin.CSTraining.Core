namespace LoafThePenguin.CSTraining.Core.Cycles;

/// <summary>
/// Алгоритм определения всех простых чисел от 1 до <see cref="int.MaxValue"/> включительно.
/// </summary>
public sealed class AllSimpleNumbersToIntMaxValueAlgorithm : IAlgorithm<IEnumerable<int>>
{
    private readonly IsNumberSimpleAlgorithm _isNumberSimpleAlgorithm;

    /// <summary>
    /// Создаёт экземпляр алгоритма определения всех простых чисел от 1 до <see cref="int.MaxValue"/> включительно.
    /// </summary>
    public AllSimpleNumbersToIntMaxValueAlgorithm() => _isNumberSimpleAlgorithm = new IsNumberSimpleAlgorithm();

    /// <inheritdoc/>
    public IEnumerable<int> Run()
    {
        for (int i = 1; i <= int.MaxValue; i++)
        {
            if (_isNumberSimpleAlgorithm.Run(i))
            {
                yield return i;
            }
        }
    }
}
