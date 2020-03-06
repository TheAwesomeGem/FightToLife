using TheCardGameLib;

namespace TheCardGameConsole
{
    /***
     * Construct anything non-data class related here. For example a class that doesn't store state, a single instance class
     * or a class that manages ownership of a sequence of data.
     */
    public static class DepedencyFactory
    {
        public static Game CreateGame()
        {
            return new GameImpl();
        }

        public static UIOutput CreateUIOutput()
        {
            return new ConsoleUIOutput();
        }

        public static UIInput CreateUIInput()
        {
            return new ConsoleUIInput();
        }

        public static InputReader CreateInputReader(UIInput uiInput)
        {
            return new ConsoleInputReader(uiInput);
        }

        public static CommandFactory CreateCommandFactory(Game game)
        {
            return new GameCommandFactory(game);
        }

        public static CommandParser CreateCommandParser(InputReader inputReader, CommandFactory commandFactory)
        {
            return new ConsoleCommandParser(inputReader, commandFactory);
        }

        public static Logger CreateLogger(UIOutput uiOutput)
        {
            return new GeneralLogger(uiOutput);
        }

        public static CommandExecutor CreateCommandExecutor(CommandParser commandParser, Logger logger)
        {
            return new CommandExecutorImpl(commandParser, logger);
        }
    }
}