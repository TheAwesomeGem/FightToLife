using System.Collections.Generic;

namespace TheCardGameLib
{
    public class ShutdownCommand : GameCommand
    {
        private readonly Game Game;

        public ShutdownCommand(Game game)
        {
            Game = game;
        }

        public void Execute(List<string> commandArgs)
        {
            Game.Shutdown();
        }
    }
}