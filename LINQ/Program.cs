namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> FootballTeams = new List<string>() { "Dallas Cowboys", "Eagles", "Falcons", "The Saints", "The Bears", "Miami Dolphins" };

            var orderByLength = FootballTeams.OrderBy(x => x.Length).ToList();

            foreach (var x in orderByLength)
            {
                Console.WriteLine(x);
            }
        }
    }
}
