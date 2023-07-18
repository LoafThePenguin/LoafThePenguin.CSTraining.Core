using LoafThePenguin.Helpers;

namespace LoafThePenguin.CSTraining.Core.Tasks.Basic;

/// <summary>
/// Алгоритм регистронезависимого сравнения двух строк.
/// </summary>
public sealed class InsensitiveStringsEqualityAlgorithm : IAlgorithm<string, string, bool>
{
    /// <summary>
    /// Создаёт экземпляр алгоритма регистронезависимого сравнения двух строк.
    /// </summary>
    public InsensitiveStringsEqualityAlgorithm()
    {

    }

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="input1">
    /// <inheritdoc/>
    /// </param>
    /// <param name="input2">
    /// <inheritdoc/>
    /// </param>
    /// <returns>
    /// <see langword="true"/>, если две строки регистронезависимо равны. 
    /// Иначе - <see langword="false"/>
    /// </returns>
    /// <exception cref="NullReferenceException">
    /// Выбрасывается, когда <paramref name="input1"/> или <paramref name="input1"/> является <see langword="null"/>.
    /// </exception>
    public bool Run(string input1, string input2)
    {
        _ = ThrowHelper.ThrowIfArgumentNull(input1);
        _ = ThrowHelper.ThrowIfArgumentNull(input2);

        return input1.ToUpper() == input2.ToUpper();
    }
}
