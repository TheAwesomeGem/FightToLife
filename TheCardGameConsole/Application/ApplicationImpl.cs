using TheCardGameLib;

namespace TheCardGameConsole
{
    public class ApplicationImpl : Application
    {
        private readonly Game Game;
        private readonly CommandExecutor CommandExecutor;

        private bool Running;

        public ApplicationImpl(Game game, CommandExecutor commandExecutor)
        {
            Game = game;
            CommandExecutor = commandExecutor;

            Running = true;

            InitEvent();
        }

        public void Run()
        {
            while (Running)
            {
                CommandExecutor.Execute();
            }
        }

        public void Shutdown()
        {
            Running = false;
        }

        private void InitEvent()
        {
            Game.StateChangeEvent += (_, state) =>
            {
                if (GameState.QUIT == state)
                {
                    Shutdown();
                }
            };
        }
    }
}