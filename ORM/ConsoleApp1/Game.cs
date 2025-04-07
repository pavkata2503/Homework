using ConsoleApp1;

public class Game
{
    Player red = new Player();

    Player blue = new Player();


    Random rnd = new Random();
    public int probability { get; set; }
    public Game()
    {
        probability = rnd.Next(1, 11);
        CreateGame();
    }
    public void CreateGame()
    {
        red.TeamName = "Red Team";
        blue.TeamName = "Blue Team";
        if (probability % 2 == 0)
        {
            blue.PlayerArrows = new List<Arrow>()
            {
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(10),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow()
            };

            blue.PlayerBallons = new List<Ballon>()
            {
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon("Black"),
                new Ballon(),
                new Ballon(),
                new Ballon()
            };

            red.PlayerArrows = new List<Arrow>()
            {
                new Arrow(10),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow(),
                new Arrow()
            };

            red.PlayerBallons = new List<Ballon>()
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
                new Ballon()
            };


        }
        else
        {
            blue.PlayerArrows = new List<Arrow>()
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
                new Arrow()
            };

            blue.PlayerBallons = new List<Ballon>()
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
                new Ballon()
            };

            red.PlayerArrows = new List<Arrow>()
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
                new Arrow()
            };

            red.PlayerBallons = new List<Ballon>()
            {
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon(),
                new Ballon("Black"),
                new Ballon(),
                new Ballon(),
                new Ballon()
            };
        }

    }

    public void StartGame()
    {
        int countblue = 0;
        int countred = 0;
        int blueindex = 0;
        int redindex = 0;
        for (int i = 0; i < 10; i++)
        {
            if (blue.PlayerBallons[blueindex].Type == "Black")
            {
                if (red.PlayerBallons[redindex].Type != "Black" && red.PlayerArrows[redindex].Accuracy >= red.PlayerBallons[redindex].BallonSize)
                {
                    countred++;
                    red.Score += red.PlayerBallons[redindex].BallonPoints;
                    redindex++;
                }
            }
            if (blue.PlayerBallons[blueindex].Type != "Black" &&  blue.PlayerArrows[blueindex].Accuracy >= blue.PlayerBallons[blueindex].BallonSize)
            {
                countblue++;
                blue.Score += blue.PlayerBallons[blueindex].BallonPoints;
                blueindex ++;
            }
            if (red.PlayerBallons[redindex].Type != "Black" && red.PlayerArrows[redindex].Accuracy >= red.PlayerBallons[redindex].BallonSize)
            {
                countred++;
                red.Score += red.PlayerBallons[redindex].BallonPoints;
                redindex++;
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