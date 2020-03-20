using System.Collections.Generic;
using NUnit.Framework;
using TheCardGameConsole;

namespace TheCardGameTest
{
    [TestFixture]
    public class CommandUtilTest
    {
        [Test]
        public void ConvertRawCommand_WithSlash_GetFormattedCmd()
        {
            // Given: A command called '/test'
            const string rawCommand = "/test";
            
            // When: ConvertRawCommand is called
            string command = CommandUtil.ConvertRawCommand(rawCommand);
            
            // Verify: The command is properly formatted
            Assert.That(command, Is.EqualTo("test"));
        }
        
        [Test]
        public void ConvertRawCommand_WithoutSlash_GetFormattedCmd()
        {
            // Given: A command called '/test'
            const string rawCommand = "test";
            
            // When: ConvertRawCommand is called
            string command = CommandUtil.ConvertRawCommand(rawCommand);
            
            // Verify: The command is properly formatted
            Assert.That(command, Is.EqualTo("test"));
        }

        [Test]
        public void SplitLineToArgs_WithNullLine_GetEmptyArgs()
        {
            // Given: A null line
            const string line = null;
            
            // When: SplitLineToArgs is called
            List<string> arguments = CommandUtil.SplitLineToArgs(line, ' ');
            
            // Verify: That the arguments are empty
            Assert.That(arguments, Is.Empty);
        }
        
        [Test]
        public void SplitLineToArgs_WithValidLine_GetValidArgs()
        {
            List<string> expectedArguments = new List<string>{ "hey", "now", "brown", "cow" };
            // Given: A null line
            const string line = "hey now brown cow";

            // When: SplitLineToArgs is called
            List<string> arguments = CommandUtil.SplitLineToArgs(line, ' ');
            
            // Verify: That the elements matched.
            Assert.That(arguments, Is.EqualTo(expectedArguments));
        }
    }
}