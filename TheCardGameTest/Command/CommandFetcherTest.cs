using Moq;
using NUnit.Framework;
using TheCardGameConsole;
using TheCardGameLib;

namespace TheCardGameTest
{
    [TestFixture]
    public class CommandFetcherTest
    {
        private Mock<GameCommand> MockCommand;
        private CommandFetcher CommandFetcher;

        [SetUp]
        public void Setup()
        {
            MockCommand = new Mock<GameCommand>();
            CommandFetcher = new CommandFetcherImpl(
                new[] {MockCommand.Object}
            );
        }

        [Test]
        public void GetCommandFromName_InvalidCommand_ThrowUnknownCommandException()
        {
            // Given: An invalid command
            const string command = "invalid";

            // When: GetCommandFromName is called
            // Verify: That the UnknownCommandException is properly being thrown
            Assert.Throws<UnknownCommandException>(() => CommandFetcher.FetchCommandFromName(command));
        }

        [Test]
        public void GetCommandFromName_ValidCommand_ReturnCommand()
        {
            // Given: A valid command
            const string command = "shutdown";
            MockCommand.Setup(cmd => cmd.HasInput(command)).Returns(true);

            // When: GetCommandFromName is called
            GameCommand gameCommand = CommandFetcher.FetchCommandFromName(command);

            // Verify: That the gameCommand is valid
            Assert.That(gameCommand, Is.EqualTo(MockCommand.Object));
        }
    }
}