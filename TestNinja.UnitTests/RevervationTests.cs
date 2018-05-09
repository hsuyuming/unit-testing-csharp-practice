
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class RevervationTests
    {
        /*[TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        {
            //Arrange
            var revervation = new Reservation();

            //Act
            var result = revervation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUserChancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            //Arrange
            var revervation = new Reservation { MadeBy = user };

            //Act
            var result = revervation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_Returnfalse()
        {

            //Arrange
            var revervation = new Reservation();

            //Act
            var result = revervation.CanBeCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);
        }
*/



        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnTrue()
        {
            //Arrange
            var revervation = new Reservation();

            //Act
            var result = revervation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            var user = new User();
            //Arrange
            var revervation = new Reservation { MadeBy = user };

            //Act
            var result = revervation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_Returnfalse()
        {

            //Arrange
            var revervation = new Reservation();

            //Act
            var result = revervation.CanBeCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);
        }
    }
}
