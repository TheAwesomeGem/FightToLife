using System;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class CommandProcessorImpl : CommandProcessor
    {
        private readonly InputReader InputReader;
        private readonly CommandParser CommandParser;
        private readonly Logger Logger;

        public CommandProcessorImpl(InputReader inputReader, CommandParser commandParser, Logger logger)
        {
            InputReader = inputReader;
            CommandParser = commandParser;
            Logger = logger;
        }

        public void Process()
        {
            InputData inputData;
            GameCommand command;
            
            try
            {
                inputData = InputReader.GetInputDataFromLine(Console.ReadLine());
                command = CommandParser.GetCommandFromInputData(inputData);
            }
            catch (UnknownCommandException ex)
            {
                Logger.LogWarning(ex.Message);
                
                return;
            }

            command.SetArguments(inputData.Arguments);
            command.Execute();
        }
    }
}