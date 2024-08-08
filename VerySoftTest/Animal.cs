using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySoftTest
{
    //public enum Mood
    //{
    //    MOOD_SCARE,
    //    MOOD_HAPPY
    //}
    abstract class Animal
    {
        protected bool isMammal;

        protected bool isCarnivorous;

        //private Mood mood;

        protected int mood;

        public readonly int MOOD_SCARE = 2;

        public readonly int MOOD_HAPPY = 1;


        public Animal(bool isMammal, bool isCarnivorous,int mood)
        {
            this.isMammal = isMammal;

            this.isCarnivorous = isCarnivorous;

            if (mood == MOOD_SCARE || mood == MOOD_HAPPY)
            {
                this.mood = mood;
            }
        }



        public virtual void SayHello()
        {
        }
        public abstract void SayHello(int mood);

        public void SetMammal(bool isMammal)
        {
            this.isMammal = isMammal;
        }

        public bool IsMammal()
        {
            return this.isMammal;
        }

        public void SetCarnivorous(bool isCarnivorous)
        {
            this.isCarnivorous = isCarnivorous;
        }

        public bool IsCarnivorous()
        {
            return this.isCarnivorous;
        }

    }
}
