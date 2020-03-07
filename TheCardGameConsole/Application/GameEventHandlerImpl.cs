using System;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class GameEventHandlerImpl : GameEventHandler
    {
        private readonly Application Application;
        private readonly Game Game;

        public GameEventHandlerImpl(Application application, Game game)
        {
            Application = application;
            Game = game;

            Game.ShutdownEvent += GameQuitHandle;
        }

        private void GameQuitHandle(object sender, EventArgs eventArgs)
        {
            Application.Shutdown();
        }
    }
}