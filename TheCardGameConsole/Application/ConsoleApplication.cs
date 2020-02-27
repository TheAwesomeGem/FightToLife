using System;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class ConsoleApplication : Application
    {
        private bool Running;

        private CommandProcessor CommandProcessor;
        
        public ConsoleApplication()
        {
            Running = true;

            InitializeDependencies();
        }

        public void Run()
        {
            while (Running)
            {
                CommandProcessor.Process();
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
            CommandProcessor = DepedencyFactory.CreateCommandProcessor(inputReader, commandParser, logger);
        }
    }
}