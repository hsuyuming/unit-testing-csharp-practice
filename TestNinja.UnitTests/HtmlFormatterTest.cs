using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTest
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var farmatter = new HtmlFormatter();

            var result = farmatter.FormatAsBold("abc");

            //Specific Asssert(Default:case sensitive)
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //            //More general (If return is error message)
            //            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            //            Assert.That(result, Does.EndWith("</strong>"));
            //            Assert.That(result, Does.Contain("abc"));
        }

    }
}