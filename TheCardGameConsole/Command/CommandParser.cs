using TheCardGameLib;

namespace TheCardGameConsole
{
    public interface CommandParser
    {
        GameCommand ParseCurrentCommand();
    }
}