using System;

namespace TheCardGameLib
{
    public class UnknownCommandException : Exception
    {
        public string CommandName { get; }

        public UnknownCommandException(string commandName)
        {
            CommandName = commandName;
        }

        public override string Message => $"Unknown Command: {CommandName}";
    }
}