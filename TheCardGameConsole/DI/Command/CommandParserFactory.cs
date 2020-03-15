namespace TheCardGameConsole
{
    public static class CommandParserFactory
    {
        public static CommandParser Get()
        {
            return new CommandParserImpl(
                InputReaderFactory.Get(),
                CommandMapperFactory.Get()
            );
        }
    }
}