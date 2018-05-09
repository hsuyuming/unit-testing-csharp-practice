
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //SetUp
        //TearDown
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }



        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArg()
        {

            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FisrstArugmentIsGreater_ReturnTheFirstArgument()
        {

            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArugmentIsGreater_ReturnTheSecondArgument()
        {

            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Max_ArugumentsAreEqual_ReturnTheSameArugument()
        {

            var result = _math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));

        }


        [Test]
        [Ignore("This is to generic. Because I wanted to!")]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_RetrunTheGreaterArugument(int a, int b, int exceptedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(exceptedResult));
        }

        //image the method is blackbox when you see that. Think of this method as a black box.
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            //            Assert.That(result, Is.Not.Empty);
            //
            //            Assert.That(result.Count(), Is.EqualTo(3));

            //            Assert.That(result, Does.Contain(1));
            //            Assert.That(result, Does.Contain(3));
            //            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));


            //            Assert.That(result,Is.Ordered);
            //            Assert.That(result, Is.Unique);
        }
    }
}