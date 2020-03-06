using System.Collections.Generic;

namespace TheCardGameLib
{
    public interface GameCommand
    {
        void PopulateArguments(List<string> commandArgs);
        void Execute();
    }
}