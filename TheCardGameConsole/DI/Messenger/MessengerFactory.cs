using TheCardGameLib;

namespace TheCardGameConsole
{
    public static class MessengerFactory
    {
        private static Messenger Instance;

        public static Messenger Get()
        {
            return Instance ??= new MessengerImpl(UIOutputFactory.Get());
        }
    }
}