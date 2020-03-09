using System.Drawing;
using TheCardGameConsole;

namespace TheCardGameLib
{
    public class MessengerImpl : Messenger
    {
        protected readonly UIOutput UIOutput;

        public MessengerImpl(UIOutput uiOutput)
        {
            UIOutput = uiOutput;
        }

        public void OutputMessage(string message)
        {
            UIOutput.OutputText(message, Color.Silver);
        }
    }
}