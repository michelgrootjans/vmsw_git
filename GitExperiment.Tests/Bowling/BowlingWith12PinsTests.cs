using NUnit.Framework;

namespace GitExperiment.Tests.Bowling
{
    [TestFixture]
    public class BowlingWith12PinsTests
    {
        private BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame(12);
        }

        [Test]
        public void Roll_5_5_IsNoSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(5);

            Assert.That(game.GetScore(), Is.EqualTo((5 + 5) + (5)));
        }

        [Test]
        public void Roll_10_1_IsNoStrike()
        {
            game.Roll(10);
            game.Roll(1);
            game.Roll(2);
            game.Roll(3);

            Assert.That(game.GetScore(), Is.EqualTo((10 + 1) + (2 + 3)));
        }

        [Test]
        public void Roll_6_6_2_Is_Spare()
        {
            game.Roll(6);
            game.Roll(6);
            game.Roll(2);
            game.Roll(3);

            Assert.That(game.GetScore(), Is.EqualTo((6 + 6 + 2) + (2 + 3)));
        }

        [Test]
        public void Roll_12_Is_Strike()
        {
            game.Roll(12);
            game.Roll(2);
            game.Roll(3);

            Assert.That(game.GetScore(), Is.EqualTo((12 + 2 + 3) + (2 + 3)));
        }

        [Test]
        public void Rolling_a_prefect_game_scores_360()
        {
            for (var roll = 0; roll < 12; roll++)
            {
                game.Roll(12);
            }
            Assert.That(game.GetScore(), Is.EqualTo((12*3)*10));
        }

    }
}