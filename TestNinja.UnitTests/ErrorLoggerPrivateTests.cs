using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerPrivateTests
    {
        //        [Test]
        //        public void OnErrorLogged_WhenCalled_RaiseEvent()
        //        {
        //            var logger = new ErrorLoggerPrivate();
        //
        //
        //            logger.OnErrorLogged(Guid.NewGuid());
        //
        //            Assert.That(true);
        //        }


        //        [Test]
        //        public void OnErrorLogged_WhenCalled_RaiseEvent2()
        //        {
        //            var logger = new ErrorLoggerPrivate();
        //
        //
        //            logger.OnErrorLogged();
        //
        //            Assert.That(true);
        //        }

        //        [Test]
        //        public void OnErrorLogged_WhenCalled_RaiseEvent3()
        //        {
        //            var logger = new ErrorLoggerPrivate();
        //
        //
        //            logger.OnErrorLogged();
        //
        //            Assert.That(true);
        //        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {

            var logger = new ErrorLoggerPrivate();

            var id = Guid.Empty;

            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}