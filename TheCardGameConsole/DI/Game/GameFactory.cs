using TheCardGameLib;

namespace TheCardGameConsole
{
    public static class GameFactory
    {
        private static Game Instance;

        public static Game Get()
        {
            return Instance ??= new GameImpl();
        }
    }
}