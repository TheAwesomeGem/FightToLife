using System;

namespace TheCardGameConsole
{
    public class UnknownCommandException : Exception
    {
        public InputData InputData { get; }

        public UnknownCommandException(InputData inputData)
        {
            InputData = inputData;
        }

        public override string Message => $"Unknown Command: { InputData.FullCommand }";
    }
}