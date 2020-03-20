namespace TheCardGameConsole
{
    public static class CommandGeneratorFactory
    {
        public static CommandGenerator Get()
        {
            return new CommandGeneratorImpl();
        }
    }
}