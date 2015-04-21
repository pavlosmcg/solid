using System;

namespace ImplementingSRP
{
    public class ExceptionLogger 
    {
        public void Log(Exception ex)
        {
            //Log the exception somewhere useful
        }
    }

    public class Customer
    {
        private ExceptionLogger _exceptionLogger;

        public Customer(ExceptionLogger exceptionLogger)
        {
            _exceptionLogger = exceptionLogger;
        }

        public void Add()
        {
            try
            {
                //Code to save the customer record to the database goes here.
            }
            catch (Exception ex)
            {
                _exceptionLogger.Log(ex);
            }
        }
    }

#region Why is this better than the example that Breaks SRP?
// The Customer class is responsible for Adding data to the database, and delegates 
// responsibility of logging any exceptions to the ExceptionLogger class.
// The ExceptionLogger knows nothing about the Customer class, and is responsible only for logging exceptions.
//
// Now if we want to change where we write our exception messages we make the change in one place, 
// and this cascades to all consumers of the ExceptionLogger for free.

// However
// While we have improved our code, we are still breaking another SOLID Principle.
// We shall come back to this example later when we talk about the Dependency Inversion Principle.
#endregion
}