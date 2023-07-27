using LoafThePenguin.CSTraining.Core.Tasks.Basic;

namespace LoafThePenguin.CSTraining.Core.Tests.Tasks.Basic;

public sealed class GetCharFromStringBySequenceAlgorithmTests
{
    private const int TIMEOUT = 1000;
    private const string DISPLAY_NAME = "Буква строки по порядку";
    private const string ANE_THROWS = $"Выбрасывает {nameof(ArgumentNullException)}";
    private const string IOE_THROWS_SEQ_EQUALS_ZERO = $"Выбрасывает {nameof(InvalidOperationException)} (Порядковый номер - 0)";
    private const string IOE_THROWS_SEQ_LOWER_ZERO = $"Выбрасывает {nameof(InvalidOperationException)} (Порядковый меньше 0)";
    private const string MESSAGE_IOE_THROWS_SEQ_EQUALS_ZERO = $"Сообщение для {nameof(InvalidOperationException)} (Порядковый номер - 0)";
    private const string MESSAGE_IOE_THROWS_SEQ_LOWER_ZERO = $"Сообщение для {nameof(InvalidOperationException)} (Порядковый меньше 0)";

    private readonly GetCharFromStringBySequenceAlgorithm _algorithm;

    public GetCharFromStringBySequenceAlgorithmTests() => _algorithm = new GetCharFromStringBySequenceAlgorithm();

    [Theory(Timeout = TIMEOUT, DisplayName = DISPLAY_NAME)]
    [InlineData("abc", 3, 'c')]
    [InlineData("DJfsfdj", 5, 'f')]
    [InlineData("9300234c", 3, '0')]
    [InlineData("GFsdgh", 5, 'g')]
    [InlineData("GFsdgh", 6, 'h')]
    [InlineData("GFsdgh", 8, null)]
    public void GetCharFromString(string str, int index, char? expected)
    {
        Assert.Equal(expected, _algorithm.Run(str, index));
    }

    [Fact(Timeout = TIMEOUT, DisplayName = ANE_THROWS)]
    public void Throws_ANE()
    {
        Assert.Throws<ArgumentNullException>(() => _algorithm.Run(null!, 0));
    }

    [Fact(Timeout = TIMEOUT, DisplayName = IOE_THROWS_SEQ_EQUALS_ZERO)]
    public void Throws_IOE_Seq_Equals_Zero()
    {
        Assert.Throws<InvalidOperationException>(() => _algorithm.Run("abc", 0));
    }

    [Fact(Timeout = TIMEOUT, DisplayName = IOE_THROWS_SEQ_LOWER_ZERO)]
    public void Throws_IOE_Seq_Lower_Zero()
    {
        Assert.Throws<InvalidOperationException>(() => _algorithm.Run("abc", -1));
    }

    [Fact(Timeout = TIMEOUT, DisplayName = MESSAGE_IOE_THROWS_SEQ_EQUALS_ZERO)]
    public void Throws_IOE_Seq_Equals_Zero_Message()
    {
        const string EXPECTED = "Порядковый номер не может быть равен 0";

        try
        {
            _ = _algorithm.Run("abc", 0);
        }
        catch (Exception ex)
        {
            Assert.Equal(EXPECTED, ex.Message);
        }
    }

    [Fact(Timeout = TIMEOUT, DisplayName = MESSAGE_IOE_THROWS_SEQ_LOWER_ZERO)]
    public void Throws_IOE_Seq_Lower_Message()
    {
        const string EXPECTED = "Порядковый номер не может быть меньше 0";

        try
        {
            _ = _algorithm.Run("abc", -1);
        }
        catch (Exception ex)
        {
            Assert.Equal(EXPECTED, ex.Message);
        }
    }
}