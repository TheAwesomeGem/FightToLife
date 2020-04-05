using Autofac;
using TheCardGameConsole.DI;

namespace TheCardGameConsole
{
    internal static class Primary
    {
        /**
         * Write Unit Tests for everything
         * Start coding the actual game :)
         */
        public static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<GameModule>();
            builder.RegisterModule<ApplicationModule>();
            builder.RegisterModule<CommandModule>();
            var container = builder.Build();

            Application application = container.Resolve<Application>();
            application.Run();
        }
    }
}