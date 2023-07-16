namespace LoafThePenguin.CSTraining.Core.Tasks.CodeWars;

/// <summary>
/// Выдает персонализированное приветствие.
/// </summary>
public sealed class PersonalizedMessage : IAlgorithm<string, string, string>
{
    /// <summary>
    /// Сообщение при равенстве параметров.
    /// </summary>
    public const string EQUAL_MESSAGE = "Hello boss";

    /// <summary>
    /// Сообщение, если параметры не равны.
    /// </summary>
    public const string NON_EQUAL_MESSAGE = "Hello guest";

    /// <summary>
    /// Создаёт алгоритм возврата персонализированного приветствия.
    /// </summary>
    public PersonalizedMessage()
    {
        
    }

    /// <summary>
    /// Метод принимает два параметра: имя и владелец. 
    /// И, в зависимости от равенства параметров, 
    /// выводит персональное сообщение.
    /// </summary>
    /// <param name="name">Имя.</param>
    /// <param name="owner">Владелец.</param>
    /// <returns>
    /// <see cref="EQUAL_MESSAGE"/>, если параметры <paramref name="name"/> и <paramref name="owner"/> равны.
    /// Иначе - <see cref="NON_EQUAL_MESSAGE"/>.
    /// </returns>
    public string Run(string name, string owner)
    {
        return name.Equals(owner)
            ? EQUAL_MESSAGE
            : NON_EQUAL_MESSAGE;
    }
}
