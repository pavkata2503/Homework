namespace IMBD_Movies
{
    internal partial class MovieReader
    {
        public class Movie
        {
            public string Name { get; set; }
            public int ReleaseYear { get; set; }
            public int Duration { get; set; }
            public double IMDBRating { get; set; }
            public double? Metascore { get; set; }
            public string Votes { get; set; }
            public List<string> Genres { get; set; } = new List<string>();
            public string Director { get; set; }
            public string Cast { get; set; }
            public string Gross { get; set; }

            public override string ToString()
            {
                return $"{Name} ({ReleaseYear}) - Рейтинг: {IMDBRating}, Режисьор: {Director}";
            }
        }
    }
}
