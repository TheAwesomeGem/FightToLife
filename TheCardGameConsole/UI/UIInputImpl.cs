using System;

namespace TheCardGameConsole
{
    public class UIInputImpl : UIInput
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}