using System.Collections.Generic;

namespace TheCardGameConsole
{
    public class InputReaderImpl : InputReader
    {
        private readonly UIInput UIInput;

        public InputReaderImpl(UIInput uiInput)
        {
            UIInput = uiInput;
        }

        public InputData ReadCurrentInput()
        {
            string line = UIInput.ReadLine();
            List<string> arguments = CommandUtil.SplitLineToArgs(line, ' ');
            string command = arguments[0];

            return new InputData(command, arguments, line);
        }
    }
}