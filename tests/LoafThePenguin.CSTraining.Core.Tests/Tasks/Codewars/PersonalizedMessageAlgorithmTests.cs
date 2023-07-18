using LoafThePenguin.CSTraining.Core.Tasks.CodeWars;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Codewars;

public sealed class PersonalizedMessageAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Персональное приветствие";

    private readonly PersonalizedMessageAlgorithm _algorithm;

    public PersonalizedMessageAlgorithmTests() => _algorithm = new PersonalizedMessageAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData("Vasya", "Greg", PersonalizedMessageAlgorithm.NON_EQUAL_MESSAGE)]
    [InlineData("Misha", "Misha", PersonalizedMessageAlgorithm.EQUAL_MESSAGE)]
    [InlineData("", "Misha", PersonalizedMessageAlgorithm.NON_EQUAL_MESSAGE)]
    [InlineData("", "", PersonalizedMessageAlgorithm.EQUAL_MESSAGE)]
    public void PersonalizedMessage(string name, string owner, string expected)
    {
        Assert.Equal(expected, _algorithm.Run(name, owner));
    }
}
