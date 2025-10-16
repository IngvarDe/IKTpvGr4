namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //genereerib iga kord suvalised numbrid
            //1-st kuni 6-ni
            int randomNumber = new Random().Next(1, 6);

            //peate kasutama switchi, et igat numbrit näidata
            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Number is 1 ja oled luuser");
                    break;

                case 2:
                    Console.WriteLine("Number is 2 ja oled natuke parem luuser");
                    break;

                case 3:
                    Console.WriteLine("Number is 3 ja oled keskmine luuser");
                    break;

                case 4:
                    Console.WriteLine("Number is 4 ja oled tubli");
                    break;

                case 5:
                    Console.WriteLine("Number is 5 ja oled väga tubli");
                    break;

                case 6:
                    Console.WriteLine("Number is 6 ja oled parim");
                    break;

                default:
                    Console.WriteLine("Number is out of range");
                    break;

                //kui kood valmis, siis teha flowchart
            }
        }
    }
}
