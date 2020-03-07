using TheCardGameLib;

namespace TheCardGameConsole
{
    public class ConsoleCommandParser : CommandParser
    {
        private readonly InputReader InputReader;
        private readonly CommandFactory CommandFactory;

        public ConsoleCommandParser(InputReader inputReader, CommandFactory commandFactory)
        {
            InputReader = inputReader;
            CommandFactory = commandFactory;
        }

        public CommandData ParseCurrentCommand()
        {
            InputData inputData = InputReader.ReadCurrentInput();
            string commandName = FetchCommandName(inputData.Command);
            GameCommand gameCommand = CommandFactory.GetCommandFromName(commandName);

            return new CommandData(gameCommand, inputData.Arguments);
        }

        private string FetchCommandName(string rawCommand)
        {
            return rawCommand.StartsWith('/') ? rawCommand.Remove(0, 1) : rawCommand;
        }
    }
}