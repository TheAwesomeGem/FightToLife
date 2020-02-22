using TheCardGameLib;

namespace TheCardGameConsole
{
    /***
     * Construct anything non-data class related here. For example a class that doesn't store state, a single instance class
     * or a class that manages ownership of a sequence of data.
     */
    public static class ConsoleDepedencyFactory
    {
        public static CommandParser CreateCommandParser(CommandFactory commandFactory)
        {
            return new ConsoleCommandParser(commandFactory);
        }

        public static InputReader CreateInputReader()
        {
            return new ConsoleInputReader();
        }
    }
}