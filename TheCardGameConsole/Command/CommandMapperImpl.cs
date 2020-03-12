using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandMapperImpl : CommandMapper
    {
        private Dictionary<string, GameCommand> GameCommands;

        public CommandMapperImpl()
        {
            MapCommands();
        }

        public GameCommand GetCommandFromName(string commandName)
        {
            GameCommand command = GameCommands.GetValueOrDefault(commandName, null);

            if (command == null)
            {
                throw new UnknownCommandException(commandName);
            }

            return command;
        }

        private void MapCommands()
        {
            GameCommands = new Dictionary<string, GameCommand>
            {
                {"shutdown", GameCommandFactory.GetShutdownCommand()}
            };
        }
    }
}