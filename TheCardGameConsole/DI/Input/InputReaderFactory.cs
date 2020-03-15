namespace TheCardGameConsole
{
    public static class InputReaderFactory
    {
        public static InputReader Get()
        {
            return new InputReaderImpl(UIInputFactory.Get());
        }
    }
}