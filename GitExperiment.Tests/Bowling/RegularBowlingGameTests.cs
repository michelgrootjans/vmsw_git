using NUnit.Framework;

namespace GitExperiment.Tests.Bowling
{
    [TestFixture]
    public class RegularBowlingGameTests
    {
        private BowlingGame game;

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void NewGame_Scores_0()
        {
            Assert.That(game.GetScore(), Is.EqualTo(0));
        }

        [Test]
        public void Rolling_0_Scores_0()
        {
            game.Roll(0);
            Assert.That(game.GetScore(), Is.EqualTo(0));
        }

        [Test]
        public void Rolling_gutter_game_Scores_0()
        {
            for (var i = 0; i < 20; i++)
                game.Roll(0);
            
            Assert.That(game.GetScore(), Is.EqualTo(0));
        }

        [Test]
        public void Rolling_1_Scores_1()
        {
            game.Roll(1);
            Assert.That(game.GetScore(), Is.EqualTo(1));
        }

        [Test]
        public void Rolling_1_twice_Scores_2()
        {
            game.Roll(1);
            game.Roll(1);
            Assert.That(game.GetScore(), Is.EqualTo(2));
        }

        [Test]
        public void Rolling_all_ones_Scores_20()
        {
            for (var i = 0; i < 20; i++)
                game.Roll(1);

            Assert.That(game.GetScore(), Is.EqualTo(20));
        }
    }
}