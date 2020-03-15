namespace TheCardGameConsole
{
    public class ApplicationRunnerImpl : ApplicationRunner
    {
        private bool Running;

        public ApplicationRunnerImpl()
        {
            Running = true;
        }

        public bool CanRun()
        {
            return Running;
        }

        public void StopRunning()
        {
            Running = false;
        }
    }
}