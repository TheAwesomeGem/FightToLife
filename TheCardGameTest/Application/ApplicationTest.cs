using Moq;
using NUnit.Framework;
using TheCardGameConsole;
using TheCardGameLib;

namespace TheCardGameTest
{
    [TestFixture]
    public class ApplicationTest
    {
        private Mock<ApplicationRunner> ApplicationRunnerMock;
        private Mock<CommandExecutor> CommandExecutorMock;
        private Application Application;

        [SetUp]
        public void Setup()
        {
            ApplicationRunnerMock = new Mock<ApplicationRunner>();
            CommandExecutorMock = new Mock<CommandExecutor>();
            Application = new ApplicationImpl(
                ApplicationRunnerMock.Object,
                CommandExecutorMock.Object
            );
        }

        [Test]
        public void Run_WhenRunning_ExecuteCommands()
        {
            try
            {
                // Given: A valid running Application
                CommandExecutorMock.Setup(executor => executor.Execute()).Throws(new InfiniteLoopExeception());
                ApplicationRunnerMock.Setup(runner => runner.CanRun()).Returns(true);

                // When: Run is called
                Application.Run();

                // Verify: That CommandExecutor Executes.
                CommandExecutorMock.Verify(executor => executor.Execute(), Times.Once);
            }
            catch (InfiniteLoopExeception)
            {
            }
        }

        [Test]
        public void Run_WhenNotRunning_DontExecuteCommands()
        {
            // Given: A valid running Application
            ApplicationRunnerMock.Setup(runner => runner.CanRun()).Returns(false);

            // When: Run is called
            Application.Run();

            // Verify: That CommandExecutor Executes.
            CommandExecutorMock.Verify(executor => executor.Execute(), Times.Never);
        }
    }
}