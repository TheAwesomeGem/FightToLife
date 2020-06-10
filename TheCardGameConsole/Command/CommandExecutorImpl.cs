using System;
using System.Collections.Generic;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandExecutorImpl : CommandExecutor
    {
        private readonly UIInput Input;
        private readonly CommandStorage CommandStorage;
        private readonly Logger Logger;

        public CommandExecutorImpl(UIInput input, CommandStorage commandStorage, Logger logger)
        {
            Input = input;
            CommandStorage = commandStorage;
            Logger = logger;
        }

        public void Execute()
        {
            Tuple<GameCommand, List<string>> commandData;

            try
            {
                commandData = FetchCommandData();
            }
            catch (Exception ex)
            {
                Logger.LogWarning(ex.Message);

                return;
            }

            commandData.Item1.Execute(commandData.Item2);
        }

        private Tuple<GameCommand, List<string>> FetchCommandData()
        {
            InputData inputData = ReadCurrentInput();
            string commandName = inputData.Command.StartsWith('/')
                ? inputData.Command.Remove(0, 1)
                : inputData.Command;

            return new Tuple<GameCommand, List<string>>(
                CommandStorage.FetchCommandFromName(commandName),
                inputData.Arguments
            );
        }

        private InputData ReadCurrentInput()
        {
            string line = Input.ReadLine();
            List<string> arguments = line.SplitLineToArgs(' ');
            string command = arguments[0];

            return new InputData(command, arguments);
        }
    }
}
