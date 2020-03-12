namespace TheCardGameConsole
{
    public static class CommandMapperFactory
    {
        private static CommandMapper Instance;

        public static CommandMapper Get()
        {
            return Instance ??= new CommandMapperImpl();
        }
    }
}