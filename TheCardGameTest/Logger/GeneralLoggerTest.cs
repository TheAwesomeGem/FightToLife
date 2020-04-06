using System.Drawing;
using Moq;
using NUnit.Framework;
using TheCardGameConsole;

namespace TheCardGameTest
{
    [TestFixture]
    public class GeneralLoggerTest
    {
        private Mock<UIOutput> UIOutputMock;
        private Logger Logger;

        [SetUp]
        public void Setup()
        {
            UIOutputMock = new Mock<UIOutput>();
            Logger = new GeneralLogger(UIOutputMock.Object);
        }

        [Test]
        public void LogInfo_WithoutTag_VerifyDefaultTag()
        {
            const string expectedInfo = "Test Info Log Message";
            const string expectedTag = "INFO";
            string expectedText = $"[{expectedTag}] {expectedInfo}";
            Color expectedColor = Color.Green;

            Logger.LogInfo(expectedInfo);

            UIOutputMock.Verify(output => output.OutputText(expectedText, expectedColor), Times.Once);
        }
        
        [Test]
        public void LogInfo_WithTag_VerifyCustomTag()
        {
            const string expectedInfo = "Test Info Log Message";
            const string expectedTag = "CUSTOMTAG";
            string expectedText = $"[{expectedTag}] {expectedInfo}";
            Color expectedColor = Color.Green;

            Logger.LogInfo(expectedInfo, expectedTag);

            UIOutputMock.Verify(output => output.OutputText(expectedText, expectedColor), Times.Once);
        }
        
        [Test]
        public void LogWarning_WithoutTag_VerifyDefaultTag()
        {
            const string expectedInfo = "Test Warning Log Message";
            const string expectedTag = "WARNING";
            string expectedText = $"[{expectedTag}] {expectedInfo}";
            Color expectedColor = Color.Orange;

            Logger.LogWarning(expectedInfo);

            UIOutputMock.Verify(output => output.OutputText(expectedText, expectedColor), Times.Once);
        }
        
        [Test]
        public void LogWarning_WithTag_VerifyCustomTag()
        {
            const string expectedInfo = "Test Warning Log Message";
            const string expectedTag = "CUSTOMTAG";
            string expectedText = $"[{expectedTag}] {expectedInfo}";
            Color expectedColor = Color.Orange;

            Logger.LogWarning(expectedInfo, expectedTag);

            UIOutputMock.Verify(output => output.OutputText(expectedText, expectedColor), Times.Once);
        }
        
        [Test]
        public void LogError_WithoutTag_VerifyDefaultTag()
        {
            const string expectedInfo = "Test Error Log Message";
            const string expectedTag = "ERROR";
            string expectedText = $"[{expectedTag}] {expectedInfo}";
            Color expectedColor = Color.Red;

            Logger.LogError(expectedInfo);

            UIOutputMock.Verify(output => output.OutputText(expectedText, expectedColor), Times.Once);
        }
        
        [Test]
        public void LogError_WithTag_VerifyCustomTag()
        {
            const string expectedInfo = "Test Error Log Message";
            const string expectedTag = "CUSTOMTAG";
            string expectedText = $"[{expectedTag}] {expectedInfo}";
            Color expectedColor = Color.Red;

            Logger.LogError(expectedInfo, expectedTag);

            UIOutputMock.Verify(output => output.OutputText(expectedText, expectedColor), Times.Once);
        }
    }
}