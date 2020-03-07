using System;

namespace TheCardGameLib
{
    public interface Game
    {
        public event EventHandler ShutdownEvent;
        public GameState State { get; }

        void Progress();
        void Shutdown();
    }
}