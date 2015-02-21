using NUnit.Framework;

namespace GitExperiment.Tests.Bowling
{
    [TestFixture]
    public class StrikeBowlingGameTests
    {
        private BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void Strike_counts_next_2_rolls_double()
        {
            game.Roll(10);
            game.Roll(2);
            game.Roll(3);

            Assert.That(game.GetScore(), Is.EqualTo((10 + 2 + 3) + (2 + 3)));
        }

        [Test]
        public void Rolling_a_prefect_game_scores_300()
        {
            for (var roll = 0; roll < 12; roll++)
            {
                game.Roll(10);
            }
            Assert.That(game.GetScore(), Is.EqualTo(300));
        }

    }
}