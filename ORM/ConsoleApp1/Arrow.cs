public class Arrow
{
    public int Accuracy { get; set; }
    public int Points { get; set; } = 0;
    public Arrow()
    {
        Random rnd = new Random();
        Accuracy = rnd.Next(0, 101);
    }
    public Arrow(int points)
    {
        Random rnd = new Random();
        Accuracy = rnd.Next(0, 101);
        Points = points;
    }
}
