using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftTest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Dog(false, false, 2);

            animals[1] = new Cat(true, false, 1);

            animals[2] = new Frog(true, false, 1);

            Console.WriteLine("----------array---------");

            foreach (var animal in animals)
            {
                animal.SayHello(-1);//polimorphizm
                if (animal is ILand)
                    Console.WriteLine("I have " +(animal as ILand).GetNumberOfLegs() +" legs"); 
            }


            Console.WriteLine("----------dog---------");

            Dog dog = new Dog(true, false, 1);

            dog.SayHello();

            dog.SayHello(-1);//if the function gets -1 it uses the mood which initialised in the constructor; 

            dog.SayHello(2);//if it gets 1 or 2 it changes the mood and then print the suitable massage; 

            Console.WriteLine("----------frog---------");

            Frog frog =new Frog(true, false, 2);

            frog.SayHello(-1);

            if (frog.HasGills()==true&& frog.HasLaysEggs() == true)
            {
                Console.WriteLine("it works!!!");
            }

            Console.WriteLine("----------cat---------");

            Cat cat = new Cat(true, false, 2);

            cat.SayHello();

            cat.SayHello(-1);



        }
    }
}
