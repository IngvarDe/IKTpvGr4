namespace RandomColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iga kord tuleb number suvaline number!");

            int color = new Random().Next(0, 3);

            if (color == 0)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine("Green");
            }
            else if (color == 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Red");
            }
            else if (color == 2)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("Blue");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
