namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGameNames = new List<string>()
            {
                "Spiderman",
                "Wii Sports Resort",
                "Super Mario Bros",
                "The Legend of Zelda",
                "Sonic the Hedgehog"

            };

            var gamesOrderedByLength = videoGameNames.OrderBy(game => game.Length).ToList();
            gamesOrderedByLength.ForEach(game => Console.WriteLine(game));
        }
    }
}
