using System;

namespace TheCardGameLib
{
    public class GameImpl : Game
    {
        public event EventHandler<GameState> StateChangeEvent;

        private GameState State;

        public GameImpl()
        {
            State = GameState.MENU;
        }

        public void Progress()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            SwitchState(GameState.QUIT);
        }

        public void SwitchState(GameState newState)
        {
            State = newState;

            StateChangeEvent?.Invoke(this, State);
        }
    }
}