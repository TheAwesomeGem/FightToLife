using System.Collections.Generic;

namespace TheCardGameConsole
{
    public interface GameCommand
    {
        bool HasInput(string name);

        IEnumerable<string> GetInputs();
        
        void Execute(List<string> commandArgs);
    }
}