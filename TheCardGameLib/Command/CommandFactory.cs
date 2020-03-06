namespace TheCardGameLib
{
    public interface CommandFactory
    {
        GameCommand GetCommandFromName(string commandName);
    }
}