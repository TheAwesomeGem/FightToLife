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
        private Mock<UIInput> InputMock;
        private Mock<CommandStorage> CommandStorageMock;
        private Mock<Logger> LoggerMock;
        private CommandExecutor CommandExecutor;

        [SetUp]
        public void Setup()
        {
            InputMock = new Mock<UIInput>();
            CommandStorageMock = new Mock<CommandStorage>();
            LoggerMock = new Mock<Logger>();
            CommandExecutor = new CommandExecutorImpl(
                InputMock.Object,
                CommandStorageMock.Object,
                LoggerMock.Object
            );
        }

        [Test]
        public void Execute_WithUnknownCommand_LogUnknownCommandException()
        {
            // Given: An exception of Invalid Command Data 
            const string cmd = "unknown";
            var exception = new UnknownCommandException(cmd);
            InputMock.Setup(input => input.ReadLine()).Returns($"/{cmd}");
            CommandStorageMock.Setup(parser => parser.FetchCommandFromName(cmd))
                .Throws(exception);

            // When: Execute is called
            CommandExecutor.Execute();

            // Verify: Execption thrown is being logged
            LoggerMock.Verify(logger => logger.LogWarning(exception.Message, ""));
        }
    }
}
