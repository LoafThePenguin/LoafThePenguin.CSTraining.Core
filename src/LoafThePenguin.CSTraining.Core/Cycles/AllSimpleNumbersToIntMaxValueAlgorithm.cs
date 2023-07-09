namespace LoafThePenguin.CSTraining.Core.Cycles;

/// <summary>
/// Алгоритм определения всех простых чисел от 1 до <see cref="int.MaxValue"/> включительно.
/// </summary>
public sealed class AllSimpleNumbersToIntMaxValueAlgorithm : IAlgorithm<int[]>
{
    private readonly IsNumberSimpleAlgorithm _isNumberSimpleAlgorithm;

    /// <summary>
    /// Создаёт экземпляр алгоритма определения всех простых чисел от 1 до <see cref="int.MaxValue"/> включительно.
    /// </summary>
    public AllSimpleNumbersToIntMaxValueAlgorithm() => _isNumberSimpleAlgorithm = new IsNumberSimpleAlgorithm();

    /// <inheritdoc/>
    public int[] Run()
    {
        int[] simpleNumbers = new int[int.MaxValue];
        IEnumerable<int[]> chunks = Enumerable
            .Range(1, int.MaxValue)
            .Chunk(int.MaxValue / 1000);
        Parallel.ForEach(chunks, chunk =>
        {
            foreach(int number in chunk)
            {
                simpleNumbers[number - 1] = number;
            }
        });

        return simpleNumbers;
    }
}
