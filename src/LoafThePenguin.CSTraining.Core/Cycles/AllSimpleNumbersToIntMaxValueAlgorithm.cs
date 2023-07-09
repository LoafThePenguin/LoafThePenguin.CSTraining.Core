using System.Collections.Concurrent;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoafThePenguin.CSTraining.Core.Cycles;

/// <summary>
/// Алгоритм определения всех простых чисел от 1 до <see cref="int.MaxValue"/> включительно.
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
