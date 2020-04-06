using NUnit.Framework;
using TheCardGameLib;

namespace TheCardGameTest
{
    [TestFixture]
    public class GameTest
    {
        private Game Game;

        [SetUp]
        public void Setup()
        {
            Game = new GameImpl();
        }

        [Test]
        public void Init_StateDefault()
        {
            Assert.That(Game.State, Is.EqualTo(GameState.MENU));
        }

        [Test]
        public void SwitchState_UpdateStateWithNewState()
        {
            GameState newState = GameState.FIGHT;

            Game.SwitchState(newState);

            Assert.That(Game.State, Is.EqualTo(newState));
        }
    }
}