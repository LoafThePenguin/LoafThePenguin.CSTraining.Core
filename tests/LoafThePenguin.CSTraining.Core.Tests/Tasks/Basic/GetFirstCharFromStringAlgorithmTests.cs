using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

public sealed class GetFirstCharFromStringAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Первая буква строки";
    private const string NRE_THROWS = $"Выбрасывает {nameof(ArgumentNullException)}";

    private readonly GetFirstCharFromStringAlgorithm _algorithm;

    public GetFirstCharFromStringAlgorithmTests() => _algorithm = new GetFirstCharFromStringAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData("", null)]
    [InlineData("DJfsfdj", 'D')]
    [InlineData("9300234c", '9')]
    [InlineData("abc", 'a')]
    public void GetFirstCharFromString(string str, char? expected)
    {
        Assert.Equal(expected, _algorithm.Run(str));
    }

    [Fact(Timeout = TIMEOUT, DisplayName = NRE_THROWS)]
    public void Throws_NRE()
    {
        Assert.Throws<NullReferenceException>(() => _algorithm.Run(null!));
    }
}
