namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //bool on andmetüüp ja ainult true ning false
            //ei või ja
            bool check = false;
            bool negative = false;

            //byte max väärtus on 256
            //0 käsitleb arvuti meie mõttes, kui positiivset väärtust
            //byte saab olla ainult positiivne
            byte a = 255;

            //saab käsitleda negatiivseid ja positiivseid numbreid
            //8-biti ulatuses
            sbyte b = -127;

            //mis on char?
            //üks tähemörk
            char ch = 'a';
            char numberCh = '5';
            //mis on sulud number 5 ees?
            //sulud numbri ees on castimine
            char numberCh1 = (char)5;

            //decimal
            //decimal muutuja nimega decim peab võrduma 2.1
            decimal decim = 2.1m;
            decimal decim1 = (decimal)2.1;

            //double
            //mis on double eripära?
            //see on komakohaga arv
            double doub = 12.4;

            //float
            //float muutuja nimega floating peab võrduma 2.145
            //tehke ise ära
            float floating = 2.145f;

            //int e täisarv
            //32 bitine
            //komakohaga arve ei saa panna
            int täisarv = 2345;

            //uint
            //mis on uinti eripära?
            //uint saab lisada ainult positiivseid täisarve
            uint asd = 234;

            //nint
            //eripära on selles, et kui protsessor on 32 bit-ne,
            //siis kohandub 32-biti peale
            //64 biti puhul kohandub 64 biti peale
            nint asd123 = 123;

            //long
            //64 bitine arv
            //long max väärtus on 9 223 372 036 854 775 807
            long longNumber = 2222222222222222222;

            //short
            //16 bitine arv
            short shortNumber = 123;

            //ushort
            //mis on ushort?
            //ainult positiivsed numbrid
            ushort shorterNumber = 123;

            //string
            //mis on string?
            //see on tähemärk
            string someString = "asdert124345@$%^&*()";
            //allpool olev ei ole arvuti jaoks number
            string stringInt = "123";
        }
    }
}
