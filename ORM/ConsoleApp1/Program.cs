namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player blue = new Player();
            blue.TeamName = "Blue Team";
            int countblue = 0;

            Arrow arrow = new Arrow();
            arrow.Accuracy = 50;

            Player red = new Player();
            red.TeamName = "Red Team";
            int countred = 0;

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
public class Ballon
{
    public int BallonSize { get; private set; }
    public Ballon()
    {
        Random rnd = new Random();
        BallonSize = rnd.Next(0, 101);
    }

}
public class Arrow
{
    public int Accuracy { get; set; }
    public Arrow()
    {
        Random rnd = new Random();
        Accuracy = rnd.Next(0, 101);
    }
}

public class Player: Game
{
    public string TeamName { get; set; } = null!;
    
}

public class Game
{
    public List<Arrow> Arrows { get; set; } = new List<Arrow>()
    {
        new Arrow(),
        new Arrow(),
        new Arrow(),
        new Arrow(),
        new Arrow(),
        new Arrow(),
        new Arrow(),
        new Arrow(),
        new Arrow(),
        new Arrow(),
    };
    public List<Ballon> Ballons { get; set; } = new List<Ballon>()
    {
        new Ballon(),
        new Ballon(),
        new Ballon(),
        new Ballon(),
        new Ballon(),
        new Ballon(),
        new Ballon(),
        new Ballon(),
        new Ballon(),
        new Ballon(),
    };
}