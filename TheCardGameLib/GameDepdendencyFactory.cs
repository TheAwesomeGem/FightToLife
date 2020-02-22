namespace TheCardGameLib
{
    /***
     * Construct anything non-data class related here. For example a class that doesn't store state, a single instance class
     * or a class that manages ownership of a sequence of data.
     */
    public static class GameDepdendencyFactory
    {
        public static Game CreateGame()
        {
            return new GameImpl();
        }

        public static CommandFactory CreateCommandFactory(Game game)
        {
            return new GameCommandFactory(game);
        }
    }
}