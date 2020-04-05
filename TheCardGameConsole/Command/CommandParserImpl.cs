using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandParserImpl : CommandParser
    {
        private readonly InputReader InputReader;
        private readonly CommandFetcher CommandFetcher;

        public CommandParserImpl(InputReader inputReader, CommandFetcher commandFetcher)
        {
            InputReader = inputReader;
            CommandFetcher = commandFetcher;
        }

        public CommandData ParseCurrentCommand()
        {
            InputData inputData = InputReader.ReadCurrentInput();
            string commandName = CommandUtil.ConvertRawCommand(inputData.Command);
            GameCommand gameCommand = CommandFetcher.FetchCommandFromName(commandName);

            return new CommandData(gameCommand, inputData.Arguments);
        }
    }
}