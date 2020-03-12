using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandParserImpl : CommandParser
    {
        private readonly InputReader InputReader;
        private readonly CommandMapper CommandMapper;

        public CommandParserImpl(InputReader inputReader, CommandMapper commandMapper)
        {
            InputReader = inputReader;
            CommandMapper = commandMapper;
        }

        public CommandData ParseCurrentCommand()
        {
            InputData inputData = InputReader.ReadCurrentInput();
            string commandName = FetchCommandName(inputData.Command);
            GameCommand gameCommand = CommandMapper.GetCommandFromName(commandName);

            return new CommandData(gameCommand, inputData.Arguments);
        }

        private string FetchCommandName(string rawCommand)
        {
            return rawCommand.StartsWith('/') ? rawCommand.Remove(0, 1) : rawCommand;
        }
    }
}