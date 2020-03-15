using TheCardGameLib;

namespace TheCardGameConsole
{
    public static class GameCommandFactory
    {
        public static GameCommand GetShutdownCommand()
        {
            return new ShutdownCommand(ApplicationFactory.Get());
        }
    }
}