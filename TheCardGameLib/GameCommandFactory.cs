using System.Collections.Immutable;

namespace TheCardGameLib
{
    public class GameCommandFactory : CommandFactory
    {
        public IImmutableDictionary<string, GameCommand> GameCommands { get; private set; }

        private readonly Game Game;

        public GameCommandFactory(Game game)
        {
            Game = game;
            
            Initialize();
        }

        private void Initialize()
        {
            var builder = ImmutableDictionary.CreateBuilder<string, GameCommand>();
            builder.Add("shutdown", new ShutdownCommand(Game));

            GameCommands = builder.ToImmutable();
        }
    }
}