using System.Drawing;
using Moq;
using NUnit.Framework;
using TheCardGameConsole;
using TheCardGameLib;

namespace TheCardGameTest
{
    [TestFixture]
    public class MessengerTest
    {
        private Mock<UIOutput> UIOutputMock;
        private Messenger Messenger;

        [SetUp]
        public void Setup()
        {
            UIOutputMock = new Mock<UIOutput>();
            Messenger = new MessengerImpl(UIOutputMock.Object);
        }

        [Test]
        public void OutputMessage_Test()
        {
            const string expectedMessage = "Test Message";
            Color expectedColor = Color.Silver;

            Messenger.OutputMessage(expectedMessage);

            UIOutputMock.Verify(output => output.OutputText(expectedMessage, expectedColor), Times.Once);
        }
    }
}