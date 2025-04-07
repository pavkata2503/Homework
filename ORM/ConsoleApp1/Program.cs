namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.CreateGame();

            for (int i = 0; i < 10; i++)
            {
                if (blue.Arrows[i].Accuracy >= blue.Ballons[i].BallonSize)
                {
                    countblue++;
                }
                if (red.Arrows[i].Accuracy >= red.Ballons[i].BallonSize)
                {
                    countred++;
                }

            }
            if (countblue > countred)
            {
                Console.WriteLine($"Blue Team Wins {countblue}");
            }
            else if (countblue < countred)
            {
                Console.WriteLine($"Red Team Wins {countred}");
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}
