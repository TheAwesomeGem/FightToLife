using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandExecutorImpl : CommandExecutor
    {
        private readonly CommandParser CommandParser;
        private readonly Logger Logger;

        public CommandExecutorImpl(CommandParser commandParser, Logger logger)
        {
            CommandParser = commandParser;
            Logger = logger;
        }

        public void Execute()
        {
            CommandData commandData;

            try
            {
                commandData = CommandParser.ParseCurrentCommand();
            }
            catch (UnknownCommandException ex)
            {
                Logger.LogWarning(ex.Message);

                return;
            }

            commandData.GameCommand.Execute(commandData.Arguments);
        }
    }
}