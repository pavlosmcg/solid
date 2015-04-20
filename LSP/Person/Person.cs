using System;

namespace PersonPrisoner
{
    public class Person
    {
        public virtual void WalkNorth(int miles)
        {
            Console.WriteLine("{0} walked {1} miles north", GetType().Name, miles);
        }

        public virtual void WalkEast(int miles)
        {
            Console.WriteLine("{0} walked {1} miles east", GetType().Name, miles);
        }

        public virtual void WalkSouth(int miles)
        {
            Console.WriteLine("{0} walked {1} miles south", GetType().Name, miles);
        }

        public virtual void WalkWest(int miles)
        {
            Console.WriteLine("{0} walked {1} miles west", GetType().Name, miles);
        }
    }
}