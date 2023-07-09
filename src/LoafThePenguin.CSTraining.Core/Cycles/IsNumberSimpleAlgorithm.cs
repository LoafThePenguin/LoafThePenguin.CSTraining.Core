namespace LoafThePenguin.CSTraining.Core.Cycles;

/// <summary>
/// Алгоритм проверки на простоту числа.
/// </summary>
public sealed class IsNumberSimpleAlgorithm : IAlgorithm<int, bool>
{
    /// <summary>
    /// Создаёт экземпляр алгоритма проверки на простоту числа.
    /// </summary>
    public IsNumberSimpleAlgorithm()
    {
        
    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="input">
    /// <inheritdoc/>
    /// </param>
    /// <returns><see langword="true"/>, если число простое. Иначе - <see langword="false"/>.</returns>
    public bool Run(int input)
    {
        for (int divider = 2; divider < input / 2; divider++)
        {
            if (input % divider == 0)
            {
                return false;
            }
        }

        return true;
    }
}
