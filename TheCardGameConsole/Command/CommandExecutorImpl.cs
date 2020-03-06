using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandExecutorImpl : CommandExecutor
    {
        private readonly InputReader InputReader;
        private readonly CommandParser CommandParser;
        private readonly Logger Logger;

        public CommandExecutorImpl(InputReader inputReader, CommandParser commandParser, Logger logger)
        {
            InputReader = inputReader;
            CommandParser = commandParser;
            Logger = logger;
        }

        public void Execute()
        {
            InputData inputData;
            GameCommand command;

            try
            {
                inputData = InputReader.ReadCurrentInput();
                command = CommandParser.GetCommandFromInputData(inputData);
            }
            catch (UnknownCommandException ex)
            {
                Logger.LogWarning(ex.Message);

                return;
            }

            command.Execute(inputData.Arguments);
        }
    }
}