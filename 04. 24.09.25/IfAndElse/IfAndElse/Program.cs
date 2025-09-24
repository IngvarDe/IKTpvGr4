namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimi");

            string muutuja = Console.ReadLine();

            if (muutuja == "")
            {
                Console.WriteLine("Ei sisestanud nime");
            }
            else 
            {
                Console.WriteLine("Sisestasid nime " + muutuja);
            }
        }
    }
}
