namespace LoafThePenguin.CSTraining.Core.Basic.Cycles;

/// <summary>
/// Алгоритм определения всех простых чисел в дипазоне от 1 до <see cref="int.MaxValue"/> включительно.
/// </summary>
public sealed class AllSimpleNumbersToIntMaxValueAlgorithm : IAlgorithm<int, IEnumerable<int>>
{
    private readonly IsNumberSimpleAlgorithm _isNumberSimpleAlgorithm;

    /// <summary>
    /// Создаёт экземпляр алгоритма определения всех простых чисел от 1 до <see cref="int.MaxValue"/> включительно.
    /// </summary>
    public AllSimpleNumbersToIntMaxValueAlgorithm() => _isNumberSimpleAlgorithm = new IsNumberSimpleAlgorithm();

    /// <inheritdoc/>
    /// <param name="count">
    /// Количество чисел.
    /// </param>
    public IEnumerable<int> Run(int count)
    {
        int returnsCount = 0;
        int nextNubmer = 1;
        while (returnsCount < count && nextNubmer <= int.MaxValue)
        {
            if (_isNumberSimpleAlgorithm.Run(nextNubmer))
            {
                yield return nextNubmer;
                returnsCount++;
            }

            nextNubmer++;
        }
    }
}
