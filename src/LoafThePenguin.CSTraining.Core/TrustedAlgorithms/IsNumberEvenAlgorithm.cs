namespace LoafThePenguin.CSTraining.Core.TrustedAlgorithms
{
    public sealed class IsNumberEvenAlgorithm : IAlgorithm<int, bool>
    {
        public bool Run(int input)
        {
            return input % 2 == 0;
        }
    }
}
