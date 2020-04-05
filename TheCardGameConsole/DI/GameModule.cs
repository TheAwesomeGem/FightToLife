using Autofac;
using TheCardGameLib;

namespace TheCardGameConsole.DI
{
    public class GameModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GameImpl>().As<Game>();
            builder.RegisterType<GeneralLogger>().As<Logger>();
            builder.RegisterType<MessengerImpl>().As<Messenger>();
        }
    }
}