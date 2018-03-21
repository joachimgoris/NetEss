using System;

namespace oefening
{
    internal class Program
    {
        private static void Main()
        {
            Animal anim2 = new Dog("Pluto");
            Animal anim3 = new SmallDog("Fifike");

            //PrintAnimal(anim1);
            PrintAnimal(anim2);
            PrintAnimal(anim3);

            //Console.WriteLine(anim1.ToString());
            Console.WriteLine(anim2.ToString());
            Console.WriteLine(anim3.ToString());

            anim2.SetName("Tibo");
            Console.WriteLine(anim2.GetName);

            Console.ReadLine();
        }

        private static void PrintAnimal(Animal anim)
        {
            string line = $"animal ({anim.GetName}) sounds as: {anim.Sound()}";
            
            Console.WriteLine(line);
        }
        

    }
}
