namespace TheCardGameLib
{
    public class ShutdownCommand : BaseGameCommand
    {
        private readonly Game Game;

        public ShutdownCommand(Game game)
        {
            Game = game;
        }

        public override void Execute()
        {
            Game.Shutdown();
        }
    }
}