using NUnit.Framework;

namespace ImplementingDIP
{
    [TestFixture]
    public class TestCustomer
    {
        [Test]
        public void ShouldBeAbleToCreateCustomerWithIExceptionLogger()
        {
            var customer = new Customer(new ExceptionLogger());

            Assert.True(true);
        }

        [Test]
        public void ShouldBeAbleToCreateCustomerWithIExceptionLoggerPro()
        {
            var customer = new Customer(new ExceptionLoggerPro());

            Assert.True(true);
        }
    }
}