using System.Drawing;
using Colorful;

namespace TheCardGameConsole
{
    public class ConsoleUIOutput : UIOutput
    {
        public void OutputText(string text, Color color)
        {
            Console.WriteLine(text, color);
        }
    }
}