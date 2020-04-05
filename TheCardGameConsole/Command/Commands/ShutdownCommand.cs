using System.Collections.Generic;

namespace TheCardGameConsole
{
    public class ShutdownCommand : BaseGameCommand
    {
        private readonly ApplicationRunner ApplicationRunner;

        public ShutdownCommand(ApplicationRunner applicationRunner)
            : base("shutdown")
        {
            ApplicationRunner = applicationRunner;
        }

        public override void Execute(List<string> commandArgs)
        {
            ApplicationRunner.StopRunning();
        }
    }
}