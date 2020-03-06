using System.Drawing;

namespace TheCardGameConsole
{
    public interface UIOutput
    {
        void OutputText(string text, Color color);
    }
}