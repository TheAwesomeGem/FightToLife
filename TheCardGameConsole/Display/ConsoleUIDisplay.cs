using System.Drawing;
using Colorful;

namespace TheCardGameConsole
{
    public class ConsoleUIDisplay : UIDisplay
    {
        public void DisplayText(string text, Color color)
        {
            Console.WriteLine(text, color);
        }
    }
}