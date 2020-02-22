using System.Collections.Immutable;

namespace TheCardGameLib
{
    public class GameImpl: Game
    {
        public GameState State { get; private set; } = GameState.READY;
        public CommandFactory CommandFactory { get; }
        public Tournament Tournament { get; }

        public GameImpl()
        {
            CommandFactory = GameDepdendencyFactory.CreateCommandFactory(this);
        }

        public void Progress()
        {
            throw new System.NotImplementedException();
        }

        public void Shutdown()
        {
            State = GameState.SHUTDOWN;
        }
    }
}