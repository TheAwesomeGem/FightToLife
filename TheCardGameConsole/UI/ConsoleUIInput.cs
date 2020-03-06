using System;

namespace TheCardGameConsole
{
    public class ConsoleUIInput : UIInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}