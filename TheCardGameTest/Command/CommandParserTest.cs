using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TheCardGameConsole;

namespace TheCardGameTest
{
    [TestFixture]
    public class CommandParserTest
    {
        private Mock<InputReader> InputReaderMock;
        private Mock<CommandFetcher> CommandFetcherMock;
        private CommandParser CommandParser;

        [SetUp]
        public void Setup()
        {
            InputReaderMock = new Mock<InputReader>();
            CommandFetcherMock = new Mock<CommandFetcher>();

            CommandParser = new CommandParserImpl(
                InputReaderMock.Object,
                CommandFetcherMock.Object
            );
        }

        [Test]
        public void ParseCurrentCommand_Test()
        {
            const string commandName = "shutdown";
            Mock<GameCommand> mockGameCommand = new Mock<GameCommand>();
            InputData inputData = new InputData($"/{commandName}", new List<string>());
            InputReaderMock.Setup(reader => reader.ReadCurrentInput()).Returns(inputData);
            CommandFetcherMock.Setup(fetcher => fetcher.FetchCommandFromName(commandName))
                .Returns(mockGameCommand.Object);

            CommandData commandData = CommandParser.ParseCurrentCommand();

            CommandFetcherMock.Verify(fetcher => fetcher.FetchCommandFromName(commandName), Times.Once);
            Assert.That(commandData.Arguments, Is.Empty);
            Assert.That(commandData.GameCommand, Is.EqualTo(mockGameCommand.Object));
        }
    }
}