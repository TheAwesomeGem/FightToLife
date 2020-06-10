using System;
using System.Collections.Generic;
using System.Linq;

namespace TheCardGameConsole
{
    public static class StringExt
    {
        public static List<string> SplitLineToArgs(this string line, char seperator)
        {
            var rawArgs = line?.Split(seperator) ?? Array.Empty<string>();
            
            return rawArgs.Where(arg => arg != null).ToList();
        }
    }
}