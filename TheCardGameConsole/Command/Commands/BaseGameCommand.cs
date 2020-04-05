using System.Collections.Generic;
using System.Linq;

namespace TheCardGameConsole
{
    public abstract class BaseGameCommand : GameCommand
    {
        private readonly IEnumerable<string> Inputs;

        protected BaseGameCommand(params string[] inputs)
        {
            Inputs = inputs;
        }

        public bool HasInput(string name)
        {
            return Inputs.Contains(name);
        }

        public IEnumerable<string> GetInputs()
        {
            return new List<string>(Inputs);
        }

        public abstract void Execute(List<string> commandArgs);
    }
}