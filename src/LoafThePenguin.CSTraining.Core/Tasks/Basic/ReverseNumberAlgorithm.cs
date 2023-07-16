namespace LoafThePenguin.CSTraining.Core.Basic.Cycles;

/// <summary>
/// Алгоритм преобразования числа на зеркальное значение.
/// </summary>
/// <remarks>
/// Ввод -> 12345; Вывод -> 54321.
/// </remarks>
public sealed class ReverseNumberAlgorithm : IAlgorithm<int, int>
{
    /// <summary>
    /// Создаёт экземпляр алгоритма преобразования числа на зеркальное значение.
    /// </summary>
    public ReverseNumberAlgorithm()
    {

    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="input">
    /// <inheritdoc/>
    /// </param>
    /// <returns>
    /// Возвращает зеркальное число.
    /// </returns>
    public int Run(int input)
    {
        int reversed = 0;

        do
        {
            reversed *= 10;
            reversed += input % 10;
            input /= 10;
        } while (input != 0);

        return reversed;
    }
}
