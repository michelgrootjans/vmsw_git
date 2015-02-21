using NUnit.Framework;

namespace GitExperiment.Tests.Bowling
{
    [TestFixture]
    public class SpareBowlingGameTests
    {
        private BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void Rolling_spare_scores_next_roll_double()
        {
            game.Roll(3);
            game.Roll(7);
            game.Roll(2);
            Assert.That(game.GetScore(), Is.EqualTo((3+7+2) + (2)));
        }

        [Test]
        public void Rolling_all_fives_scores_150()
        {
            for (int i = 0; i < 21; i++)
            {
                game.Roll(5);
            }
            Assert.That(game.GetScore(), Is.EqualTo(150));
        }

    }
}
