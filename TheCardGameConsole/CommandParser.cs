using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public interface CommandParser
    {
        GameCommand GetCommandFromInputData(InputData inputData);
    }
}