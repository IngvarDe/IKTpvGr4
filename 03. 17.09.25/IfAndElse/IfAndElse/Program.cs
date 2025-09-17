namespace IfAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha if ja else konsoolirakendus");
            Console.WriteLine("Sisesta number");

            //pean sisestama numbri läbi konsooli
            string number = Console.ReadLine();
            int y = int.Parse(number);


            //if kontrollib, kas number on suurem kui 189 või 
            //väiksem
            if (y >= 189)
            {
                //esimese if sees on omakorda if ja else
                //seal kontrollitakse, kas number on suurem kui 200
                // või väiksem
                if (y < 200)
                {
                    Console.WriteLine("Number on väiksem, kui 200");
                    Console.WriteLine("Sinu number on " + y);
                }
                else
                {
                    Console.WriteLine("Number on suurem, kui 200");
                    Console.WriteLine("Sinu number on " + y);
                }
            }
            else
            {
                Console.WriteLine("Sinu number on väiksem, kui 189");
            }
        }
    }
}
