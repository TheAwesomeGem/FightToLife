namespace TheCardGameLib
{
    public interface Game
    {
        public GameState State { get; }

        void Progress();
        void SwitchState(GameState newState);
    }
}