namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var soccerTeams = new List<string>() { "Manchester City","Arsenal", "Chelsea", "Manchester United","Liverpool","Tottenham","Aston Villa"};

            var nameLength = soccerTeams.OrderBy(team => team.Length);

            foreach (string team in nameLength)
            {
               Console.WriteLine(team);
            }

            
        }
    }
}
