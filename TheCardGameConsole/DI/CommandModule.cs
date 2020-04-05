using Autofac;

namespace TheCardGameConsole.DI
{
    public class CommandModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ShutdownCommand>().As<GameCommand>();
        }
    }
}