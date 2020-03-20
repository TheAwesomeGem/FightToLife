using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TheCardGameConsole;
using TheCardGameLib;

namespace TheCardGameTest
{
    [TestFixture]
    public class CommandParserTest
    {
        private Mock<InputReader> InputReaderMock;
        private Mock<CommandMapper> CommandMapperMock;
        private CommandParser CommandParser;

        [SetUp]
        public void Setup()
        {
            InputReaderMock = new Mock<InputReader>();
            CommandMapperMock = new Mock<CommandMapper>();
            CommandParser = new CommandParserImpl(
                InputReaderMock.Object,
                CommandMapperMock.Object
            );
        }

        [Test]
        public void ParseCurrentCommand_WithValidData_GetValidCommandData()
        {
            // Given: A valid command data
            const string commandName = "/shutdown";
            List<string> args = new List<string>();
            GameCommand shutdownCommand = GameCommandFactory.GetShutdownCommand();
            CommandData expectedCommandData = new CommandData(
                shutdownCommand,
                args
            );
            InputReaderMock.Setup(inputReader => inputReader.ReadCurrentInput()).Returns(
                new InputData(commandName, args)
            );
            CommandMapperMock.Setup(mapper => mapper.GetCommandFromName(CommandUtil.ConvertRawCommand(commandName)))
                .Returns(
                    shutdownCommand
                );

            // When: ParseCurrentCommand is called
            CommandData commandData = CommandParser.ParseCurrentCommand();

            // Verify: That the command matches the expected command data.
            Assert.That(commandData.GameCommand, Is.SameAs(expectedCommandData.GameCommand));
            Assert.That(commandData.Arguments, Is.SameAs(expectedCommandData.Arguments));
        }
    }
}