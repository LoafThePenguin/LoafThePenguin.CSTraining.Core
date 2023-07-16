using LoafThePenguin.CSTraining.Core.Tasks.CodeWars;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Codewars;

public sealed class PersonalizedMessageTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Персональное приветствие";

    private readonly PersonalizedMessage _algorithm;

    public PersonalizedMessageTests() => _algorithm = new PersonalizedMessage();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData("Vasya", "Greg", Core.Tasks.CodeWars.PersonalizedMessage.NON_EQUAL_MESSAGE)]
    [InlineData("Misha", "Misha", Core.Tasks.CodeWars.PersonalizedMessage.EQUAL_MESSAGE)]
    [InlineData("", "Misha", Core.Tasks.CodeWars.PersonalizedMessage.NON_EQUAL_MESSAGE)]
    [InlineData("", "", Core.Tasks.CodeWars.PersonalizedMessage.EQUAL_MESSAGE)]
    public void PersonalizedMessage(string name, string owner, string expected)
    {
        Assert.Equal(expected, _algorithm.Run(name, owner));
    }
}
