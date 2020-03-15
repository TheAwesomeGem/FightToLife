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
            string commandName = CommandUtil.ConvertRawCommand(inputData.Command);
            GameCommand gameCommand = CommandMapper.GetCommandFromName(commandName);

            return new CommandData(gameCommand, inputData.Arguments);
        }
    }
}