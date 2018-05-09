using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerContollerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);


            //Not Found Object
            Assert.That(result, Is.TypeOf<NotFound>());

            //            //Not or one of its derivatives
            //            Assert.That(result, Is.InstanceOf<NotFound>());
            //
            //            Assert.That(result, Is.InstanceOf<ActionResult>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOK()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}