using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftTest
{
    internal class Frog : Animal,Water,Land
    {
        private int NumberOfLegs = 4;

        public Frog(bool isMammal, bool isCarnivorous, int mood) : base(isMammal, isCarnivorous, mood)
        {
        }

        public int GetNumberOfLegs()
        {
            return NumberOfLegs;
        }

        public bool HasGills()
        {
            return true;
        }

        public bool HasLaysEggs()
        {
            return true;
        }

        public override void SayHello(int mood)
        {
            if (mood != -1)
            {
                this.mood = mood;
            }
            if (this.mood == MOOD_HAPPY)
            {
                Console.WriteLine("quack, quack, quack");
                return;
            }
            if (this.mood == MOOD_SCARE)
            {
                Console.WriteLine("I flopped into water");
            }
        }
    }
}
