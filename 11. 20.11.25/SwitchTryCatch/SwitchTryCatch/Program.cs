namespace SwitchTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch koos Switch-ga");

            //alguses teha switch kus saab sisestada numbreid 1 ja 2
            Console.WriteLine("Sisesta number 1 või 2");

            try
            {

                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Sisestasid number 1");
                        break;

                    case 2:
                        Console.WriteLine("Sisestasid number 2");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta kehtiv number.");
            }
            //Miks tuleb see error, kui sisestan
            //numbri: 444444444444444444444444444444444444444444444444444444444
            //int on 32 bitine
            //int .MaxValue = 2 147 483 647
            catch (OverflowException)
            {
                Console.WriteLine("Sisestatud number on liiga suur või liiga väike.");
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Tekkis ootamatu viga: {ex.Message}");
            //}
        }
    }
}
