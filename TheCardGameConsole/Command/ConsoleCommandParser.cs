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

        public GameCommand ParseCurrentCommand()
        {
            InputData inputData = InputReader.ReadCurrentInput();
            string commandName = inputData.Command.StartsWith('/') ? 
                                inputData.Command.Remove(0, 1) : inputData.Command;
            GameCommand gameCommand = CommandFactory.GetCommandFromName(commandName);
            gameCommand.PopulateArguments(inputData.Arguments);
            
            return gameCommand;
        }
    }
}