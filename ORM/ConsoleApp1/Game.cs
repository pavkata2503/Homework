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
    int countblue = 0;
    int countred = 0;
    public void StartGame()
    {
        int blueindex = 9;
        int redindex = 9;
        while(blueindex != 0 && redindex!=0 ) 
        {
            if (blue.PlayerBallons[blueindex].Type == "Black")
            {
                blue.PlayerArrows.RemoveAt(blueindex);
                blue.PlayerBallons.RemoveAt(blueindex);
                blueindex--;

                if (red.PlayerArrows[redindex].Accuracy >= red.PlayerBallons[redindex].BallonSize)
                {
                    countred++;
                    red.Score += red.PlayerBallons[redindex].BallonPoints;
                }

                red.PlayerArrows.RemoveAt(redindex);
                red.PlayerBallons.RemoveAt(redindex);
                redindex--;
                if (red.PlayerArrows[redindex].Accuracy >= red.PlayerBallons[redindex].BallonSize)
                {
                    countred++;
                    red.Score += red.PlayerBallons[redindex].BallonPoints;
                }

                red.PlayerArrows.RemoveAt(redindex);
                red.PlayerBallons.RemoveAt(redindex);
                redindex--;
                blue.PlayerArrows.RemoveAt(blueindex);
                blue.PlayerBallons.RemoveAt(blueindex);
                blueindex--;
            }
            else if (red.PlayerBallons[redindex].Type == "Black")
            {
                red.PlayerArrows.RemoveAt(redindex);
                red.PlayerBallons.RemoveAt(redindex);
                redindex--;

                if (blue.PlayerArrows[blueindex].Accuracy >= blue.PlayerBallons[blueindex].BallonSize)
                {
                    countblue++;
                    blue.Score += blue.PlayerBallons[blueindex].BallonPoints;
                }

                blue.PlayerArrows.RemoveAt(blueindex);
                blue.PlayerBallons.RemoveAt(blueindex);
                blueindex--;
                if (blue.PlayerArrows[blueindex].Accuracy >= blue.PlayerBallons[blueindex].BallonSize)
                {
                    countblue++;
                    blue.Score += blue.PlayerBallons[blueindex].BallonPoints;
                }

                blue.PlayerArrows.RemoveAt(blueindex);
                blue.PlayerBallons.RemoveAt(blueindex);
                blueindex--;
                red.PlayerArrows.RemoveAt(redindex);
                red.PlayerBallons.RemoveAt(redindex);
                redindex--;
            }
            else
            {
                if (blue.PlayerArrows[blueindex].Accuracy >= blue.PlayerBallons[blueindex].BallonSize)
                {
                    countblue++;
                    blue.Score += blue.PlayerBallons[blueindex].BallonPoints;
                }
                blueindex--;
                blue.PlayerArrows.RemoveAt(blueindex);
                blue.PlayerBallons.RemoveAt(blueindex);
                if (red.PlayerArrows[redindex].Accuracy >= red.PlayerBallons[redindex].BallonSize)
                {
                    countred++;
                    red.Score += red.PlayerBallons[redindex].BallonPoints;
                }
                red.PlayerArrows.RemoveAt(redindex);
                red.PlayerBallons.RemoveAt(redindex);
                redindex--;
            }
            
        }
        if (blue.Score > red.Score)
        {
            Console.WriteLine($"Blue Team Wins {blue.Score}");
        }
        else if (red.Score > red.Score)
        {
            Console.WriteLine($"Red Team Wins {red.Score}");
        }
        else
        {
            Console.WriteLine("Draw");
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Red Team Pop Ballons: {countred}");
        Console.WriteLine($"Red Team Score: {red.Score}");
        Console.WriteLine($"Blue Team Pop Ballons: {countblue}");
        Console.WriteLine($"Blue Team Score: {blue.Score}");
    }
}