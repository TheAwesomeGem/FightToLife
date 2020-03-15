using TheCardGameLib;

namespace TheCardGameConsole
{
    public static class ApplicationFactory
    {
        private static Application Instance;

        public static Application Get()
        {
            return Instance ??= new ApplicationImpl(
                ApplicationRunnerFactory.Get(),
                CommandExecutorFactory.Get()
            );
        }
    }
}