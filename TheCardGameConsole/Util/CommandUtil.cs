using System;
using System.Collections.Generic;
using System.Linq;

namespace TheCardGameConsole
{
    public static class CommandUtil
    {
        public static string ConvertRawCommand(string rawCommand)
        {
            return rawCommand.StartsWith('/') ? rawCommand.Remove(0, 1) : rawCommand;
        }

        public static List<string> SplitLineToArgs(string line, char seperator)
        {
            var rawArgs = line?.Split(seperator) ?? Array.Empty<string>();
            
            return rawArgs.Where(arg => arg != null).ToList();
        }
    }
}