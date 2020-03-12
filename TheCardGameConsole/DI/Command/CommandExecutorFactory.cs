namespace TheCardGameConsole
{
    public static class CommandExecutorFactory
    {
        private static CommandExecutor Instance;

        public static CommandExecutor Get()
        {
            return Instance ??= new CommandExecutorImpl(
                CommandParserFactory.Get(),
                LoggerFactory.Get()
            );
        }
    }
}