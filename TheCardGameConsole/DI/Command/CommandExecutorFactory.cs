namespace TheCardGameConsole
{
    public static class CommandExecutorFactory
    {
        public static CommandExecutor Get()
        {
            return new CommandExecutorImpl(
                CommandParserFactory.Get(),
                LoggerFactory.Get()
            );
        }
    }
}