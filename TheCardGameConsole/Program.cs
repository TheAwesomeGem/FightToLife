using Autofac;

namespace TheCardGameConsole
{
    internal static class Primary
    {
        /**
         * Separate unit test between Console and Lib to their own individual unit test project
         * Start coding the actual game :)
         */
        public static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(typeof(Primary).Assembly);
            var container = builder.Build();

            Application application = container.Resolve<Application>();
            application.Run();
        }
    }
}