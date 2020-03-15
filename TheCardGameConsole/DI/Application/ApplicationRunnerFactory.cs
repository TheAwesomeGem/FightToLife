namespace TheCardGameConsole
{
    public static class ApplicationRunnerFactory
    {
        public static ApplicationRunner Get()
        {
            return new ApplicationRunnerImpl();
        }
    }
}