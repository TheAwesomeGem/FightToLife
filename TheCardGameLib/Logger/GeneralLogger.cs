namespace TheCardGameConsole
{
    public class GeneralLogger : BaseLogger
    {
        public GeneralLogger(UIOutput uiOutput)
            : base(Logger.Type.ALL, uiOutput)
        {
        }
    }
}