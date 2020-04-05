using TheCardGameLib;

namespace TheCardGameConsole
{
    public class ApplicationImpl : Application
    {
        private readonly ApplicationRunner ApplicationRunner;
        private readonly CommandExecutor CommandExecutor;

        public ApplicationImpl(ApplicationRunner applicationRunner, CommandExecutor commandExecutor)
        {
            ApplicationRunner = applicationRunner;
            CommandExecutor = commandExecutor;
        }

        public void Run()
        {
            while (ApplicationRunner.CanRun())
            {
                CommandExecutor.Execute();
            }
        }
    }
}