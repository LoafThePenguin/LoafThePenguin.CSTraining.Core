using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

public sealed class TrimWhitespacesAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Удаление пробелов с начала и конца строки";
    private const string ANE_THROWS = $"Выбрасывает {nameof(ArgumentNullException)}";

    private readonly TrimWhitespacesAlgorithm _algorithm;

    public TrimWhitespacesAlgorithmTests() => _algorithm = new TrimWhitespacesAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData("")]
    [InlineData("    ")]
    [InlineData("  DJfsfdj ")]
    [InlineData(" 9300234c")]
    [InlineData(" abc ")]
    [InlineData(" abc     ")]
    [InlineData("sd fsd ff")]
    public void TrimWhitespaces(string str)
    {
        string expected = str.Trim();

        Assert.Equal(expected, _algorithm.Run(str));
    }

    [Fact(Timeout = TIMEOUT, DisplayName = ANE_THROWS)]
    public void Throws_ANE()
    {
        Assert.Throws<ArgumentNullException>(() => _algorithm.Run(null!));
    }
}
