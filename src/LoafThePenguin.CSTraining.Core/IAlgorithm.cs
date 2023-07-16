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
/// <typeparam name="TInput1">Тип входного значения 1.</typeparam>
/// <typeparam name="TInput2">Тип входного значения 2.</typeparam>
/// <typeparam name="TOutput">Тип выходного значения.</typeparam>
public interface IAlgorithm<in TInput1, in TInput2, out TOutput>
{
    /// <summary>
    /// Запускает алгоритм.
    /// </summary>
    /// <param name="input1">Входное значение 1.</param>
    /// <param name="input2">Входное значение 2.</param>
    /// <returns>Экземпляр выходного значения.</returns>
    TOutput Run(TInput1 input1, TInput2 input2);
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
