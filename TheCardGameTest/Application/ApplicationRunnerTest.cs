using NUnit.Framework;
using TheCardGameConsole;

namespace TheCardGameTest
{
    [TestFixture]
    public class ApplicationRunnerTest
    {
        private ApplicationRunner ApplicationRunner;

        [SetUp]
        public void Setup()
        {
            ApplicationRunner = new ApplicationRunnerImpl();
        }

        [Test]
        public void CanRun_WhenStopped_ReturnsFalse()
        {
            // Given: A valid Application Runner
            
            // When: StopsRunning is called
            ApplicationRunner.StopRunning();
            
            // Verify: That CanRun is now false
            Assert.That(ApplicationRunner.CanRun(), Is.False);
        }
        
        [Test]
        public void CanRun_WhenRunning_ReturnsTrue()
        {
            // Given: A valid Application Runner that is running
            
            // Verify: That CanRun is true
            Assert.That(ApplicationRunner.CanRun(), Is.True);
        }
    }
}