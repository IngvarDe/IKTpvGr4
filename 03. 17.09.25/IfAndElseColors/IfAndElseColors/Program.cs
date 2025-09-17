namespace IfAndElseColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus, kus" +
                "kontrollitakse stringi abil värvi vastavust");
            //sina sisestad värvi nimetuse ja arvuti annab vastava teksti

            Console.WriteLine("Värvide valikus on: red, blue, green ja white");

            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta " +
                "eelpool sisestatud värvi");

            string color = Console.ReadLine();

            //nüüd tuleb if ja else loogika
            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("See on punane");
            }
            else if (color == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("See on sinine");
            }
            else if (color == "green")
            {
                //see tagatausta värv
                Console.BackgroundColor = ConsoleColor.Green;
                //see on teksti värv
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("See on roheline");
            }
            else if (color == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("See on valge");
            }
            else
            {
                Console.WriteLine("See on suvaline värv");
            }
        }
    }
}
