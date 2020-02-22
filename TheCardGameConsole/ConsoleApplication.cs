using System;
using TheCardGameLib;

namespace TheCardGameConsole
{
    public class ConsoleApplication
    {
        private readonly Game Game;
        private readonly CommandParser CommandParser;
        private readonly InputReader InputReader;
        
        public ConsoleApplication()
        {
            Game = GameDepdendencyFactory.CreateGame();
            CommandParser = ConsoleDepedencyFactory.CreateCommandParser(Game.CommandFactory);
            InputReader = ConsoleDepedencyFactory.CreateInputReader();
        }

        public void Run()
        {
            while(Game.State != GameState.SHUTDOWN)
            {
                ProcessCommand();
            }
        }

        private void ProcessCommand()
        {
            InputData inputData = InputReader.GetInputDataFromLine(Console.ReadLine());
            GameCommand command = CommandParser.GetCommandFromInputData(inputData);

            if (command == null)
            {
                Console.WriteLine($"Unknown Command: {inputData.ToString()}");
                
                return;
            }
            
            command.SetArguments(inputData.Arguments);
            command.Execute();
        }
    }
}