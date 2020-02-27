namespace TheCardGameConsole
{
    public class GeneralLogger : BaseLogger
    {
        public GeneralLogger(UIDisplay uiDisplay)
            : base(Logger.Type.ALL, uiDisplay)
        {
        }
    }
}