using System.Collections.Generic;

namespace TheCardGameLib
{
    public interface GameCommand
    {
        void Execute();
        void SetArguments(List<string> commandArgs);
    }
}