namespace LoafThePenguin.CSTraining.Core.TrustedAlgorithms.Condition;

/// <summary>
/// Алгоритм проверки числа на чётность.
/// </summary>
public sealed class IsNumberEvenAlgorithm : IAlgorithm<int, bool>
{
    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="input"></param>
    /// <returns><see langword="true"/>, если число чётное. Иначе - <see langword="false"/>.</returns>
    public bool Run(int input)
    {
        return input % 2 == 0;
    }
}
