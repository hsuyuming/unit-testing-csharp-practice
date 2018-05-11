using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        [Test]
        public void CauculateDemeritPoints_SpeedIsNegative_ThrowArgumentOutOfRangeException()
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }


        [Test]
        public void CauculateDemeritPoints_SpeedIsZero_ReturnZero()
        {
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(0);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CauculateDemeritPoints_SpeedIsLessThanSpeedLimit_ReturnZero()
        {
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(64);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CauculateDemeritPoints_SpeedIsEqualThanSpeedLimit_ReturnZero()
        {
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(65);

            Assert.That(result, Is.EqualTo(0));
        }


        [Test]
        public void CauculateDemeritPoints_SpeedgreaterthanAcceptBy5DemeritPoints_ReturnExcpetDemeritPoints()
        {
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(66);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CauculateDemeritPoints_SpeedIsOver300_ThrowArgumentOutOfRangeException()
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }



        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(67, 0)]
        public void CauculateDemeritPoints_WhenCalled_ReturnDemeritPoint(int speed, int exceptResult)
        {
            var calculator = new DemeritPointsCalculator();

            var points = calculator.CalculateDemeritPoints(speed);


            Assert.That(points, Is.EqualTo(exceptResult));
        }


        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CauculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }


    }
}