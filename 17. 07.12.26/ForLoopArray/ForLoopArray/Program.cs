namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "H", "e", "l", "l", "o" };

            //vaja teha string array H, e, l, l, o
            //kasutada for loopi
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            //tuleb kasutada foreachi
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
