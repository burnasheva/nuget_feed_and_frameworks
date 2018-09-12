using NUnit.Framework;

namespace DependencyFromTeamCityFeed
{
    [TestFixture]
    public class FirstTestClass
    {
        [Test]
        public static void TestCalculatorDependency()
        {
            Assert.AreEqual(3.4, Calculator.Calculator.Plus(2.0, 1.4));
        }
    }
}