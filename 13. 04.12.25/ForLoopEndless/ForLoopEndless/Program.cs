namespace ForLoopEndless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For loop endless");

            //kasutame for loopi
            ushort i = 0;

            // kui on 10 rida konsoolis, siis lõpetab ära
            //VIHJE: kasutage break-i

            for (; ; )
            {
                Console.WriteLine("i väärtus on: {0}", i);
                i++;
                if (i > 10)
                {
                    break;
                }
            }
        }
    }
}
