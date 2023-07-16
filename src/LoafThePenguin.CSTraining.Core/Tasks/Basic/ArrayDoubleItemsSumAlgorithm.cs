namespace LoafThePenguin.CSTraining.Core.Tasks.Basic;

/// <summary>
/// Алгоритм вычисления суммы элементов массива типа <see cref="double"/>.
/// </summary>
public sealed class ArrayDoubleItemsSumAlgorithm : IAlgorithm<double[], double>
{
    /// <summary>
    /// Создаёт экземпляр алгоритма вычисления суммы элементов массива типа <see cref="double"/>.
    /// </summary>
    public ArrayDoubleItemsSumAlgorithm()
    {
        
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="input">
    /// <inheritdoc/>
    /// </param>
    /// <returns>Сумма элементов массива.</returns>
    public double Run(double[] input)
    {
        return input.Sum();
    }
}
