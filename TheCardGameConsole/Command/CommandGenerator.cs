using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public interface CommandGenerator
    {
        Dictionary<string, GameCommand> GenerateCommands();
    }
}