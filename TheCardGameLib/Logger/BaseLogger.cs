using System.Drawing;

namespace TheCardGameConsole
{
    public abstract class BaseLogger : Logger
    {
        private readonly Logger.Type Type;
        private readonly UIOutput UIOutput;

        protected BaseLogger(Logger.Type type, UIOutput uiOutput)
        {
            Type = type;
            UIOutput = uiOutput;
        }

        public void LogInfo(string info, string tag = "")
        {
            if (Type != Logger.Type.ALL)
            {
                return;
            }

            string prefix = GetPrefix(tag, "INFO");
            UIOutput.OutputText($"{prefix} {info}", Color.Green);
        }

        public void LogWarning(string warning, string tag = "")
        {
            if (Type == Logger.Type.ERROR)
            {
                return;
            }

            string prefix = GetPrefix(tag, "WARNING");
            UIOutput.OutputText($"{prefix} {warning}", Color.Orange);
        }

        public void LogError(string error, string tag = "")
        {
            string prefix = GetPrefix(tag, "ERROR");
            UIOutput.OutputText($"{prefix} {error}", Color.Red);
        }

        private string GetPrefix(string tag, string defaultTag)
        {
            return string.IsNullOrEmpty(tag) ? $"[{defaultTag}]" : $"[{tag}]";
        }
    }
}