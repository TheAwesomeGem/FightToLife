using TheCardGameLib;

namespace TheCardGameConsole
{
    public static class MessengerFactory
    {
        public static Messenger Get()
        {
            return new MessengerImpl(UIOutputFactory.Get());
        }
    }
}