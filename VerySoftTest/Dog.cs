using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftTest
{
    internal class Dog : Animal, ILand
    {
        private int numberOfLegs = 4;
        public Dog(bool isMammal, bool isCarnivorous, int mood) : base(isMammal, isCarnivorous, mood)
        {
        }

        public int GetNumberOfLegs()
        {
            return this.numberOfLegs;
        }

        public override void SayHello()
        {
            Console.WriteLine("I bit my tail");
        }

        public override void SayHello(int mood)
        {
            if (mood != -1)
            {
                this.mood = mood;
            }
            if (this.mood == MOOD_HAPPY)
            {
                Console.WriteLine("hav hav");
                return;
            }
            if (this.mood == MOOD_SCARE)
            {
                Console.WriteLine("whoop");
            }
            

        }
    }
}
