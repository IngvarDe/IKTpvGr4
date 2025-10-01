namespace OddNumberIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib nr ja muudate selle int andmetüübiks
            string nr = Console.ReadLine();
            int number = int.Parse(nr);

            //teha if ja else-ga kontroll, kus saame teada,
            //et kas nr on paaris või paaritu
            if (number %2 == 0)
            {
                Console.WriteLine("Sisestasid paaris arvu: " + number);
            }
            else
            {
                Console.WriteLine("Sisestasid paaritu arvu: " + number);
            }
            //teha vooskeem e flowchart
        }
    }
}
