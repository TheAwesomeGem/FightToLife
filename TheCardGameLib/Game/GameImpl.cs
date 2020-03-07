using System;

namespace TheCardGameLib
{
    public class GameImpl : Game
    {
        public event EventHandler ShutdownEvent;
        public GameState State { get; private set; } = GameState.MENU;

        public GameImpl()
        {
            
        }

        public void Progress()
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            ShutdownEvent?.Invoke(this, null);
        }
    }
}