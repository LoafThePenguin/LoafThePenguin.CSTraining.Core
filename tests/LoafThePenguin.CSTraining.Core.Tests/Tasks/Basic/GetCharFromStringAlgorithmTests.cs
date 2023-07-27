using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

public sealed class GetCharFromStringAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Буква строки";
    private const string ANE_THROWS = $"Выбрасывает {nameof(ArgumentNullException)}";

    private readonly GetCharFromStringAlgorithm _algorithm;

    public GetCharFromStringAlgorithmTests() => _algorithm = new GetCharFromStringAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData("", 1, null)]
    [InlineData("abc", 3, null)]
    [InlineData("ab", 3, null)]
    [InlineData("DJfsfdj", 5, 'd')]
    [InlineData("9300234c", 3, '0')]
    [InlineData("abc", 0, 'a')]
    [InlineData("GFsdgh", 5, 'h')]
    [InlineData("GFsdgh", 6, null)]
    public void GetCharFromString(string str, int index, char? expected)
    {
        Assert.Equal(expected, _algorithm.Run(str, index));
    }

    [Fact(Timeout = TIMEOUT, DisplayName = ANE_THROWS)]
    public void Throws_ANE()
    {
        Assert.Throws<ArgumentNullException>(() => _algorithm.Run(null!, 0));
    }
}
