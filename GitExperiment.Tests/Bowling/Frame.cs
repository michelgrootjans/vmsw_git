namespace GitExperiment.Tests.Bowling
{
    public class Frame
    {
        private readonly int maxNumberOfPins;
        private bool hasFirstRoll;

        public Frame(int maxNumberOfPins)
        {
            this.maxNumberOfPins = maxNumberOfPins;
        }

        public int Score { get { return FirstRoll + SecondRoll; } }
        public int FirstRoll { get; private set; }
        public int SecondRoll { get; private set; }

        public bool IsFinished { get; private set; }
        public bool IsStrike { get; private set; }
        public bool IsSpare { get; private set; }

        public void Roll(int pins)
        {
            if (IsEmpty)
            {
                FirstRoll = pins;
                hasFirstRoll = true;
                if (FirstRoll == maxNumberOfPins)
                {
                    IsFinished = true;
                    IsStrike = true;
                }
            }
            else
            {
                SecondRoll = pins;
                IsFinished = true;
                if (FirstRoll + SecondRoll == maxNumberOfPins)
                    IsSpare = true;
            }
        }

        private bool IsEmpty
        {
            get { return !hasFirstRoll; }
        }
    }
}