using System;

namespace ImplementingDIP
{
    public class ExceptionLogger : IExceptionLogger
    {
        public void Log(Exception ex)
        {
            //Log the exception somewhere useful
        }
    }

    /// <summary>
    /// Note that this is not actually being used!
    /// </summary>
    public class ExceptionLoggerPro : IExceptionLogger
    {
        public void Log(Exception ex)
        {
            //Log the exception somewhere useful
            //Also email & Text the exception detail to configured users
        }
    }

    public class Customer
    {
        private IExceptionLogger _exceptionLogger;

        public Customer(IExceptionLogger exceptionLogger)
        {
            _exceptionLogger = exceptionLogger;
        }

        public void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                _exceptionLogger.Log(ex);
            }
        }
    }

    public interface IExceptionLogger
    {
        void Log(Exception ex);
    }

#region
// Here we have changed the Customer class to depend on an interface 'IExceptionLogger' instead of 
// the concrete class ExceptionLogger.
// The rest of the Customer class is unchanged, but this subtle difference means that we now delegate 
// which implementation of IExceptionLogger the Customer will use at run time to the client 
// (in addition to the creation and configuration of that implementation).
//
// As the consumer of the Customer class, we can now use whichever implementation of IExceptionLogger we choose.
//
// The Customer class is no longer tightly coupled to the implementation of ExceptionLogger, but loosely
// coupled to IExceptionLogger.
#endregion
}