namespace LoafThePenguin.CSTraining.Core;

/// <summary>
/// Базовый интерфейс алгоритма.
/// </summary>
/// <typeparam name="TInput">Тип входного значения.</typeparam>
/// <typeparam name="TOutput">Тип выходного значения.</typeparam>
public interface IAlgorithm<in TInput, out TOutput>
{
    /// <summary>
    /// Запускает алгоритм.
    /// </summary>
    /// <param name="input">Входное значение.</param>
    /// <returns>Экземпляр выходного значения.</returns>
    TOutput Run(TInput input);
}

/// <summary>
/// Базовый интерфейс алгоритма.
/// </summary>
/// <typeparam name="TOutput">Тип выходного значения.</typeparam>
public interface IAlgorithm<out TOutput>
{
    /// <summary>
    /// Запускает алгоритм.
    /// </summary>
    /// <returns>Экземпляр выходного значения.</returns>
    TOutput Run();
}
