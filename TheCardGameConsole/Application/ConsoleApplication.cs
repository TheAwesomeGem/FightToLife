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
            UIOutput uiOutput = DepedencyFactory.CreateUIOutput();
            UIInput uiInput = DepedencyFactory.CreateUIInput();
            InputReader inputReader = DepedencyFactory.CreateInputReader(uiInput);
            CommandFactory commandFactory = DepedencyFactory.CreateCommandFactory(game);
            CommandParser commandParser = DepedencyFactory.CreateCommandParser(inputReader, commandFactory);
            Logger logger = DepedencyFactory.CreateLogger(uiOutput);
            CommandExecutor = DepedencyFactory.CreateCommandExecutor(commandParser, logger);
            DepedencyFactory.CreateGameEventHandler(this, game);
        }
    }
}