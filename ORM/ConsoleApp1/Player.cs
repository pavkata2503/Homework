public class Player 
{
    public string TeamName { get; set; } = null!;
    public int Score { get; set; }
    public List<Ballon> PlayerBallons = new List<Ballon>();
    public List<Arrow> PlayerArrows = new List<Arrow>();



}
