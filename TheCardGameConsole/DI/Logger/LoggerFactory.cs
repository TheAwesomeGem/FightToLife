namespace TheCardGameConsole
{
    public static class LoggerFactory
    {
        public static Logger Get()
        {
            return new GeneralLogger(UIOutputFactory.Get());
        }
    }
}