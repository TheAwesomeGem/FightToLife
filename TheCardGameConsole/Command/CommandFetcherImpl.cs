using System.Collections.Generic;
using System.Linq;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandFetcherImpl : CommandFetcher
    {
        private readonly IEnumerable<GameCommand> GameCommands;

        public CommandFetcherImpl(IEnumerable<GameCommand> gameCommands)
        {
            GameCommands = gameCommands;
        }

        public GameCommand FetchCommandFromName(string name)
        {
            GameCommand command = GameCommands.FirstOrDefault(cmd => cmd.HasInput(name));

            if (command == null)
            {
                throw new UnknownCommandException(name);
            }

            return command;
        }
    }
}