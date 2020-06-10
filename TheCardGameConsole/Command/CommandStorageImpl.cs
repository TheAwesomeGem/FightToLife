using System.Collections.Generic;
using System.Linq;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandStorageImpl : CommandStorage
    {
        private readonly IEnumerable<GameCommand> GameCommands;

        public CommandStorageImpl(IEnumerable<GameCommand> gameCommands)
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