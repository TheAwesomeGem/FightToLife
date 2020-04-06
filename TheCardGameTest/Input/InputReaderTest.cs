using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using TheCardGameConsole;

namespace TheCardGameTest
{
    [TestFixture]
    public class InputReaderTest
    {
        private Mock<UIInput> UIInputMock;
        private InputReader InputReader;

        [SetUp]
        public void Setup()
        {
            UIInputMock = new Mock<UIInput>();
            InputReader = new InputReaderImpl(UIInputMock.Object);
        }

        [Test]
        public void ReadCurrentInput_Test()
        {
            const string expectedCmd = "/test";
            const string expectedArg = "arg";
            string expectedLine = $"{expectedCmd} {expectedArg}";
            InputData expectedInputData = new InputData(expectedCmd, new List<string> {expectedCmd, expectedArg});
            UIInputMock.Setup(input => input.ReadLine()).Returns(expectedLine);

            InputData inputData = InputReader.ReadCurrentInput();

            UIInputMock.Verify(input => input.ReadLine(), Times.Once);
            Assert.That(inputData.Arguments, Is.EqualTo(expectedInputData.Arguments));
            Assert.That(inputData.Command, Is.EqualTo(expectedInputData.Command));
        }
    }
}