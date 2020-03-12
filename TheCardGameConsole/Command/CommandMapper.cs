using TheCardGameLib;

namespace TheCardGameConsole
{
    public interface CommandMapper
    {
        GameCommand GetCommandFromName(string commandName);
    }
}