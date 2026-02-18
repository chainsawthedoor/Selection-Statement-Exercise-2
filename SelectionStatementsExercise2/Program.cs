namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What's your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I'm not so good with Math, personally!");
                    break;
                case "science":
                    Console.WriteLine("Love science!");
                    break;
                case "pe":
                case "p.e.":
                case "physical education":    
                    Console.WriteLine("P.E. is fun!");
                    break;
                case "history":
                    Console.WriteLine("I love history too!");
                    break;
                case "geography":
                    Console.WriteLine("What a nerd!");
                    break;
                default:
                    Console.WriteLine("Hey, I like that too!");
                    break;
            }
        }
    }
}