namespace TheCardGameConsole
{
    public interface CommandFetcher
    {
        GameCommand FetchCommandFromName(string name);
    }
}