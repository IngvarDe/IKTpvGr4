namespace SwitchWeekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //tuleb kasutada switchi
            //kui on esmaspäev, siis konsoolis kuvatakse
            //"Esmaspäev on tööpäev"
            //peate kasutama DayOfWeek enumeratsiooni

            switch (DateTime.Now.DayOfWeek)
            {   
                case DayOfWeek.Monday:
                    Console.WriteLine("Esmaspäev on tööpäev");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Tahaks puhata ja on teisipäev");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Liiga palju on koolis käidud");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Neljapäev ja eelviimane koolipäev");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Lõpuks ometi reede");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Laupäev on puhkus");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Pühapäev on puhkus");
                    break;
                default:
                    break;
            }
        }
    }
}
