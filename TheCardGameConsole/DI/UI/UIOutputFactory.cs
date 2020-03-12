namespace TheCardGameConsole
{
    public static class UIOutputFactory
    {
        private static UIOutput Instance;

        public static UIOutput Get()
        {
            return Instance ??= new UIOutputImpl();
        }
    }
}