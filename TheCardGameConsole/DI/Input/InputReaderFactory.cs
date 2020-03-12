namespace TheCardGameConsole
{
    public static class InputReaderFactory
    {
        private static InputReader Instance;

        public static InputReader Get()
        {
            return Instance ??= new InputReaderImpl(UIInputFactory.Get());
        }
    }
}