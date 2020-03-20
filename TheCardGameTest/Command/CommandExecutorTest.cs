using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TheCardGameConsole;
using TheCardGameLib;

namespace TheCardGameTest
{
    [TestFixture]
    public class CommandExecutorTest
    {
        private Mock<CommandParser> CommandParserMock;
        private Mock<Logger> LoggerMock;
        private CommandExecutor CommandExecutor;

        [SetUp]
        public void Setup()
        {
            CommandParserMock = new Mock<CommandParser>();
            LoggerMock = new Mock<Logger>();
            CommandExecutor = new CommandExecutorImpl(
                CommandParserMock.Object,
                LoggerMock.Object
            );
        }

        [Test]
        public void Execute_WithInvalidData_LogThrownException()
        {
            // Given: An exception of Invalid Command Data 
            var exception = new UnknownCommandException("invalid");
            CommandParserMock.Setup(parser => parser.ParseCurrentCommand())
                .Throws(exception);

            // When: Execute is called
            CommandExecutor.Execute();

            // Verify: Execption thrown is being logged
            LoggerMock.Verify(logger => logger.LogWarning(exception.Message, ""));
        }

        [Test]
        public void Execute_WithValidData_ExecuteCommand()
        {
            // Given: A valid data
            Mock<GameCommand> gameCommandMock = new Mock<GameCommand>();
            CommandData commandData = new CommandData(
                gameCommandMock.Object,
                new List<string>()
            );
            CommandParserMock.Setup(parser => parser.ParseCurrentCommand())
                .Returns(commandData);

            // When: Execute is called
            CommandExecutor.Execute();

            // Verify: That the command is being executed
            gameCommandMock.Verify(command => command.Execute(new List<string>()), Times.Once);
        }
    }
}