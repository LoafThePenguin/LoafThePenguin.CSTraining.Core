namespace LoafThePenguin.CSTraining.Core.Basic.Cycles;

/// <summary>
/// Алгоритм расчёта суммы всех цифр числа.
/// </summary>
public sealed class DigitsSumAlgorithm : IAlgorithm<int, int>
{
    /// <summary>
    /// Создаёт экземпляр алгоритма расчёта суммы всех цифр числа.
    /// </summary>
    public DigitsSumAlgorithm()
    {
        
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="input">
    /// <inheritdoc/>
    /// </param>
    /// <returns>Сумма цифр числа.</returns>
    public int Run(int input)
    {
        const int DIVIDER = 10;

        int number = Math.Abs(input);
        int sum = 0;

        while (number > 0)
        {
            sum += number % DIVIDER;
            number /= DIVIDER;
        }

        return sum;
    }
}
