namespace TheCardGameConsole
{
    public interface CommandStorage
    {
        GameCommand FetchCommandFromName(string name);
    }
}