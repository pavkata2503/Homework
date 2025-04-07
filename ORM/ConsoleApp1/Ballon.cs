public class Ballon
{
    public int BallonSize { get; private set; }
    public int BallonPoints { get; private set; }
    public string Type { get; set; }= "Normal";
    public Ballon()
    {
        Random rnd = new Random();
        BallonSize = rnd.Next(0, 101);
        BallonPoints = rnd.Next(1, 51);
    }
    public Ballon(string type)
    {
        Random rnd = new Random();
        BallonSize = rnd.Next(0, 101);
        BallonPoints = rnd.Next(1, 51);
        Type = type;
    }

}
