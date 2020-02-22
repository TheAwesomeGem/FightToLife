using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public abstract class BaseCommandParser: CommandParser
    {
        protected CommandFactory CommandFactory { get; }
        
        protected BaseCommandParser(CommandFactory commandFactory)
        {
            CommandFactory = commandFactory;
        }
        
        public abstract GameCommand GetCommandFromInputData(InputData inputData);
    }
}