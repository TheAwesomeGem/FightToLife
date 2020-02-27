using System;

namespace TheCardGameLib
{
    public class GameImpl : Game
    {
        public GameState State { get; private set; } = GameState.MENU;

        public GameImpl()
        {
            
        }

        public void Progress()
        {
            throw new NotImplementedException();
        }
    }
}