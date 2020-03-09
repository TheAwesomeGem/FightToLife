namespace TheCardGameConsole
{
    internal static class Primary
    {
        /**
         * Implement a Module System where Game manages the module and each module can depend on Game and fetch module
         * GameCommand can use Modules to have logic.
         * Modules are like Service Container
         */
        public static void Main()
        {
            ConsoleApplication application = new ConsoleApplication();
            application.Run();
        }
    }
}