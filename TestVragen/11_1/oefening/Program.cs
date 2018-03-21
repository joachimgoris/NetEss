using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace oefening
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal anim1, anim2, anim3;
            anim1 = new Animal("Woefie");
            anim2 = new Dog("Pluto");
            anim3 = new SmallDog("Fifike");

            PrintAnimal(anim1);
            PrintAnimal(anim2);
            PrintAnimal(anim3);

            Console.ReadLine();
        }

        private static void PrintAnimal(Animal anim)
        {
            string line = String.Format("animal ({0}) sounds as: {1}", anim.name, anim.Sound());

            Console.WriteLine(line);
        }
        
    }
}
