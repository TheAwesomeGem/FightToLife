namespace TheCardGameConsole
{
    public static class UIInputFactory
    {
        private static UIInput Instance;

        public static UIInput Get()
        {
            return Instance ??= new UIInputImpl();
        }
    }
}