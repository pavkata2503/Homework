namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.CreateGame();
            game.StartGame();
            game.DisplayScore();
        }
    }
}
