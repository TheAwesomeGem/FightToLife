using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandMapperImpl : CommandMapper
    {
        private readonly CommandGenerator CommandGenerator;
        private Dictionary<string, GameCommand> GameCommands;

        public CommandMapperImpl(CommandGenerator commandGenerator)
        {
            CommandGenerator = commandGenerator;
        }

        public GameCommand GetCommandFromName(string commandName)
        {
            if (GameCommands == null)
            {
                GameCommands = CommandGenerator.GenerateCommands();
            }

            GameCommand command = GameCommands.GetValueOrDefault(commandName, null);

            if (command == null)
            {
                throw new UnknownCommandException(commandName);
            }

            return command;
        }
    }
}