using System.Drawing;
using Colorful;

namespace TheCardGameConsole
{
    public class UIOutputImpl : UIOutput
    {
        public void OutputText(string text, Color color)
        {
            Console.WriteLine(text, color);
        }
    }
}