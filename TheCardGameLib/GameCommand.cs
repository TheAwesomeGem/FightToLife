using System.Collections.Generic;
using System.Collections.Immutable;

namespace TheCardGameLib
{
    public interface GameCommand
    {
        void SetArguments(List<string> commandArgs);
        void Execute();
    }
}