namespace EnterNumberIfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta numbrid 1, 2 või 3");

            string nr = Console.ReadLine();
            int number = int.Parse(nr);
            //teha vooskeem e flowchart sellest rakendusest
            if (number == 1) 
            {
                Console.WriteLine("Sisestasid number 1");
            }
            else if (number == 2)
            {
                Console.WriteLine("Sisestasid number 2");
            }
            else if (number == 3)
            {
                Console.WriteLine("Sisestasid number 3");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
