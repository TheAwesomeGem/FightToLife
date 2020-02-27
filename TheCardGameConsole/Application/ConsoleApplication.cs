using System;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class ConsoleApplication : Application
    {
        private bool Running;

        private CommandExecutor CommandExecutor;
        
        public ConsoleApplication()
        {
            Running = true;

            InitializeDependencies();
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

        private void InitializeDependencies()
        {
            Game game = DepedencyFactory.CreateGame();
            UIDisplay uiDisplay = DepedencyFactory.CreateUiDisplay();
            CommandFactory commandFactory = DepedencyFactory.CreateCommandFactory(game);
            CommandParser commandParser = DepedencyFactory.CreateCommandParser(commandFactory);
            InputReader inputReader = DepedencyFactory.CreateInputReader();
            Logger logger = DepedencyFactory.CreateLogger(uiDisplay);
            CommandExecutor = DepedencyFactory.CreateCommandExecutor(inputReader, commandParser, logger);
        }
    }
}