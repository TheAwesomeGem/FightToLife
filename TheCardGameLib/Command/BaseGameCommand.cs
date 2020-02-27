using System.Collections.Generic;

namespace TheCardGameLib
{
    public abstract class BaseGameCommand : GameCommand
    {
        protected List<string> CommandArgs { get; private set; }

        protected BaseGameCommand()
        {
            CommandArgs = new List<string>();
        }

        public void SetArguments(List<string> commandArgs)
        {
            CommandArgs = commandArgs;
        }

        public abstract void Execute();
    }
}