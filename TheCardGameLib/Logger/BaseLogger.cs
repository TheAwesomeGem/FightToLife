using System.Drawing;

namespace TheCardGameConsole
{
    public abstract class BaseLogger : Logger
    {
        private readonly Logger.Type Type;
        private readonly UIDisplay UIDisplay;

        protected BaseLogger(Logger.Type type, UIDisplay uiDisplay)
        {
            Type = type;
            UIDisplay = uiDisplay;
        }

        public void LogInfo(string info, string tag = "")
        {
            if (Type != Logger.Type.ALL)
            {
                return;
            }

            string prefix = GetPrefix(tag, "INFO");
            UIDisplay.DisplayText($"{prefix} {info}", Color.Green);
        }

        public void LogWarning(string warning, string tag = "")
        {
            if (Type == Logger.Type.ERROR)
            {
                return;
            }

            string prefix = GetPrefix(tag, "WARNING");
            UIDisplay.DisplayText($"{prefix} {warning}", Color.Orange);
        }

        public void LogError(string error, string tag = "")
        {
            string prefix = GetPrefix(tag, "ERROR");

            UIDisplay.DisplayText($"{prefix} {error}", Color.Red);
        }

        private string GetPrefix(string tag, string defaultTag)
        {
            return string.IsNullOrEmpty(tag) ? $"[{defaultTag}]" : $"[{tag}]";
        }
    }
}