namespace TheCardGameLib
{
    public interface Game
    {
        public GameState State { get; }
        public CommandFactory CommandFactory { get; }
        public Tournament Tournament { get; }

        void Progress();
        void Shutdown();
    }
}