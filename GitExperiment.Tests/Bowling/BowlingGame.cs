using System.Collections.Generic;
using System.Linq;

namespace GitExperiment.Tests.Bowling
{
    public class BowlingGame
    {
        private readonly int maxNumberOfPins;
        private readonly int numberOfFrames;
        private readonly List<Frame> frames;

        public BowlingGame(int maxNumberOfPins = 10, int numberOfFrames = 10)
        {
            this.maxNumberOfPins = maxNumberOfPins;
            this.numberOfFrames = numberOfFrames;
            frames = new List<Frame>();
        }

        private Frame GetPlayableFrame()
        {
            if (!frames.Any() || frames.Last().IsFinished)
                frames.Add(new Frame(maxNumberOfPins));
            return frames.Last();
        }

        public void Roll(int pins)
        {
            GetPlayableFrame().Roll(pins);
        }

        public int GetScore()
        {
            var score = 0;

            for (var frame = 1; frame <= numberOfFrames; frame++)
                score += ScoreFor(frame);

            return score;
        }

        private int ScoreFor(int frameNumber)
        {
            if (Frame(frameNumber).IsStrike)
            {
                if (Frame(frameNumber + 1).IsStrike)
                    return Frame(frameNumber).Score + Frame(frameNumber + 1).Score + Frame(frameNumber + 2).FirstRoll;
                return Frame(frameNumber).Score + Frame(frameNumber + 1).Score;
            }
            if (Frame(frameNumber).IsSpare)
                return Frame(frameNumber).Score + Frame(frameNumber + 1).FirstRoll;
            return Frame(frameNumber).Score;
        }

        private Frame Frame(int frameNumber)
        {
            if (frames.Count < frameNumber)
                return new Frame(0);
            return frames[frameNumber - 1];
        }
    }
}