namespace LoafThePenguin.CSTraining.Core.TrustedAlgorithms
{
    public sealed class IsNumberSimpleAlgorithm : IAlgorithm<int, bool>
    {
        public bool Run(int input)
        {
            for (int divider = 2; divider < input / 2; divider++)
            {
                if (input % divider == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
