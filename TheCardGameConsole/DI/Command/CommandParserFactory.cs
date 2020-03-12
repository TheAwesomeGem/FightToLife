namespace TheCardGameConsole
{
    public static class CommandParserFactory
    {
        private static CommandParser Instance;

        public static CommandParser Get()
        {
            return Instance ??= new CommandParserImpl(
                InputReaderFactory.Get(),
                CommandMapperFactory.Get()
            );
        }
    }
}