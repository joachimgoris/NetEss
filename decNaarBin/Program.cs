using System;
using System.Linq;

namespace decNaarBin
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = DecNaarBin(12);
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static string DecNaarBin(int dec)
        {
            String retvalue ="";
            while (dec > 0)
            {
                if (dec % 2 == 1)
                {
                    retvalue += "1";
                }
                if (dec % 2 == 0)
                {
                    retvalue += "0";
                }
                dec = dec / 2;
            }

            return Convert.ToString(retvalue.Reverse());
        }
    }
}
