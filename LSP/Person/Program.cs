namespace PersonPrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Prisoner();
            person.WalkEast(5);
        }
    }

    #region Explanation
// At a first glance, it would be pretty obvious to make the prisoner derive from person class.
// Just as obviously, this leads us into trouble, since a prisoner is not free to move an arbitrary distance
// in any direction, yet the contract of the Person class states that a Person can.

//So, in fact, the class Person could better be named FreePerson. If that were the case, then the idea that
//class Prisoner extends FreePerson is clearly wrong.

//By analogy, then, a Square is not an Rectangle, because it lacks the same degrees of freedom as an Rectangle.
//This strongly suggests that inheritance should never be used when the sub-class restricts the freedom
//implicit in the base class. It should only be used when the sub-class adds extra detail to the concept
//represented by the base class, for example, 'Monkey' is-an 'Animal'.
    #endregion
}
