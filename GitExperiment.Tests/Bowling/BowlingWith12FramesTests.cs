using NUnit.Framework;

namespace GitExperiment.Tests.Bowling
{
    [TestFixture]
    public class BowlingWith12FramesTests
    {
        private BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame(numberOfFrames: 12);
        }

        [Test]
        public void Perfect_game_scores_360()
        {
            for (var roll = 0; roll < 14; roll++)
            {
                game.Roll(10);
            }
            Assert.That(game.GetScore(), Is.EqualTo((10 * 3) * 12));
        }


    }
}