using System;

namespace BreakingSingleResponsibility
{
    public class Customer
    {
        public void Add()
        {
            try
            {
                //Code to save the customer record to the database goes here.
            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText(@"C:\Error.txt", ex.ToString());
            }
        }
    }

    #region What's wrong with the above?
// Example of code that violates SRP – the Add method is not only concerned with adding the Customer 
// to the database, but also determines how and where exception messages are logged. 
// This should be someone else’s responsibility!

// NB: This code also decides that the only information about the exception that is useful 
// is the error message. All Stack Trace information or inner exceptions are ignored :o(


// The Customer class has 2 reasons to change:
// When we need to modify the way we save Customer data
// When we want to revise the way we log our Exceptions


// Big deal, right? But if you multiply this up over the whole system, this problem really starts to stack up.
// Let’s say you have an E-commerce web site with classes similar to this for Customers & 
// Addresses, Products & Product Categories, Orders, Wish Lists, Recommendations etc, 
// each implementing their own exception handling.
 
// Now imagine that you no longer want to log exceptions to a text file but to a database of their 
// own, or the event viewer. 
// Because each one is responsible for what to do with an exception when something goes wrong, 
// you would need to change each of these classes independently. 
// This creates a lot of work, and risk – because you risk breaking the actual function of the 
// class while you make these changes.
    #endregion
}
