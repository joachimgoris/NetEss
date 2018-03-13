using System;

namespace _8_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal visjes");
            int aantalVisjes = Convert.ToInt16(Console.ReadLine());
            for (int teller = aantalVisjes; teller>= 0; teller--)
            {
                Console.WriteLine(teller+" kleine visjes, die zwommen naar de zee.");
                Console.WriteLine("Nee, zei de moeder, ik ga niet mee.");
                Console.WriteLine("Ik blijf liever in die vieze vuile ouwe sloot.");
                Console.WriteLine("Want in de zee daar zwemt de haai en die bijt je dan... dood.");
            }

            Console.ReadLine();
        }
    }
}
