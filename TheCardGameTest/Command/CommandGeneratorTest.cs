using System.Collections.Generic;
using NUnit.Framework;
using TheCardGameConsole;

namespace TheCardGameTest
{
    [TestFixture]
    public class CommandGeneratorTest
    {
        [Test]
        public void GenerateCommands_WhenCalled_ExpectValidCommands()
        {
            // Given: A valid commandGenerator
            CommandGenerator commandGenerator = new CommandGeneratorImpl();

            // When: GenerateCommands() is called
            var result = commandGenerator.GenerateCommands();

            // Verify: That it has generated a command.
            Assert.That(result.Count, Is.Positive);
        }

        [Test]
        public void GenerateCommands_WhenCalled_ExpectShutdownCommand()
        {
            // Given: A valid commandGenerator
            CommandGenerator commandGenerator = new CommandGeneratorImpl();

            // When: GenerateCommands() is called
            var result = commandGenerator.GenerateCommands();

            // Verify: That it has the shutdown command
            Assert.NotNull(result.GetValueOrDefault("shutdown", null));
        }
    }
}