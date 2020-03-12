namespace TheCardGameConsole
{
    public static class LoggerFactory
    {
        private static Logger Instance;

        public static Logger Get()
        {
            return Instance ??= new GeneralLogger(UIOutputFactory.Get());
        }
    }
}