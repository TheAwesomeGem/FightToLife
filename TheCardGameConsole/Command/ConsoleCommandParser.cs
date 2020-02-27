using TheCardGameLib;

namespace TheCardGameConsole
{
    public class ConsoleCommandParser : BaseCommandParser
    {
        public ConsoleCommandParser(CommandFactory commandFactory)
            : base(commandFactory)
        {
        }

        public override GameCommand GetCommandFromInputData(InputData inputData)
        {
            GameCommand command = null;
            bool isValidCommand = inputData.Command.Length > 1 &&
                                  inputData.Command.StartsWith("/") &&
                                  CommandFactory.GameCommands.TryGetValue(inputData.Command.Remove(0, 1), out command);

            if (!isValidCommand || command == null)
            {
                throw new UnknownCommandException(inputData);
            }

            return command;
        }
    }
}