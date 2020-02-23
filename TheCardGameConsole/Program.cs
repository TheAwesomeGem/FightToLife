namespace TheCardGameConsole
{
    internal static class Primary
    {
        /*
         * TODO: Have a way where to can use a ClientMessage system where the Game Library can send message to display on client.
         * TODO: Have a similar system for Logger as well where Game can log message that it send to client to store/display.
         * TODO: Make use of interface for both of those systems.
         */
        public static void Main()
        {
            ConsoleApplication application = new ConsoleApplication();
            application.Run();
        }
    }
}