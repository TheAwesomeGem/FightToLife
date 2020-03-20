using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TheCardGameConsole;
using TheCardGameLib;

namespace TheCardGameTest
{
    [TestFixture]
    public class CommandMapperTest
    {
        private Mock<CommandGenerator> CommandGeneratorMock;
        private CommandMapper CommandMapper;

        [SetUp]
        public void Setup()
        {
            CommandGeneratorMock = new Mock<CommandGenerator>();
            CommandMapper = new CommandMapperImpl(CommandGeneratorMock.Object);

            CommandGeneratorMock.Setup(generator => generator.GenerateCommands()).Returns(
                new Dictionary<string, GameCommand>
                {
                    {"shutdown", new Mock<GameCommand>().Object}
                }
            );
        }

        [Test]
        public void GetCommandFromName_FirstCall_GenerateCommand()
        {
            // Given: A new first instance of CommandMapper

            // When: The first call to GetCommandFromName is being invoked
            CommandMapper.GetCommandFromName("shutdown");

            // When: The second call to GetCommandFromName is being invoked
            CommandMapper.GetCommandFromName("shutdown");

            // Verify: That the Generator has generated all the commands only once
            CommandGeneratorMock.Verify(generator => generator.GenerateCommands(), Times.Once);
        }

        [Test]
        public void GetCommandFromName_InvalidCommand_ThrowUnknownCommandException()
        {
            // Given: An invalid command
            const string command = "invalid";

            // When: GetCommandFromName is called
            // Verify: That the UnknownCommandException is properly being thrown
            Assert.Throws<UnknownCommandException>(() => CommandMapper.GetCommandFromName(command));
        }
        
        [Test]
        public void GetCommandFromName_ValidCommand_ReturnCommand()
        {
            // Given: A valid command
            const string command = "shutdown";

            // When: GetCommandFromName is called
            GameCommand gameCommand = CommandMapper.GetCommandFromName(command);
            
            // Verify: That the gameCommand is valid
            Assert.NotNull(gameCommand);
        }
    }
}