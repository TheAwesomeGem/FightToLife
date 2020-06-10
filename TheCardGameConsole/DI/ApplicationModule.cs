using Autofac;

namespace TheCardGameConsole.DI
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationImpl>().As<Application>();
            builder.RegisterType<ApplicationRunnerImpl>().As<ApplicationRunner>().SingleInstance();
            builder.RegisterType<CommandExecutorImpl>().As<CommandExecutor>();
            builder.RegisterType<CommandStorageImpl>().As<CommandStorage>();
            builder.RegisterType<UIInputImpl>().As<UIInput>();
            builder.RegisterType<UIOutputImpl>().As<UIOutput>();
        }
    }
}