using System.Collections.Generic;

namespace TheCardGameLib
{
    public class ShutdownCommand : GameCommand
    {
        private readonly Application Application;

        public ShutdownCommand(Application application)
        {
            Application = application;
        }

        public void Execute(List<string> commandArgs)
        {
            Application.Shutdown();
        }
    }
}