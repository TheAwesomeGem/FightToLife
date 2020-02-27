namespace TheCardGameConsole
{
    public interface Logger
    {
        public enum Type
        {
            ALL,
            WARNING_ERROR,
            ERROR
        }
        
        void LogInfo(string info, string tag = "");
        void LogWarning(string warning, string tag = "");
        void LogError(string error, string tag = "");
    }
}