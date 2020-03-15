using System;

namespace TheCardGameLib
{
    public class GameImpl : Game
    {
        public GameState State { get; private set; }

        public GameImpl()
        {
            State = GameState.MENU;
        }

        public void Progress()
        {
            throw new NotImplementedException();
        }

        public void SwitchState(GameState newState)
        {
            State = newState;
        }
    }
}