using System.Collections.Generic;

namespace TheCardGameLib
{
    public class GameCommandFactory : CommandFactory
    {
        private readonly Game Game;
        private Dictionary<string, GameCommand> GameCommands;

        public GameCommandFactory(Game game)
        {
            Game = game;

            Initialize();
        }

        private void Initialize()
        {
            GameCommands = new Dictionary<string, GameCommand>
            {
                {"shutdown", new ShutdownCommand(Game)}
            };
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
    }
}