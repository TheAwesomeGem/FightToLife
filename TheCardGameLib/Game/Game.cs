using System;

namespace TheCardGameLib
{
    public interface Game
    {
        public event EventHandler<GameState> StateChangeEvent;

        void Progress();
        void Quit();
        void SwitchState(GameState newState);
    }
}