using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftTest
{
    internal class Cat : Animal, ILand
    {
        private int numberOfLegs = 4;
        public Cat(bool isMammal, bool isCarnivorous, int mood) : base(isMammal, isCarnivorous, mood)
        {
        }

        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public override void SayHello()
        {
            Console.WriteLine("meow~");
        }

        public override void SayHello(int mood)
        {

            if (mood != -1)
            {
                this.mood = mood;
            }
            if (this.mood == MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr");
                return;
            }
            if (this.mood == MOOD_SCARE)
            {
                Console.WriteLine("hiss");
            }


        }
    }
}
