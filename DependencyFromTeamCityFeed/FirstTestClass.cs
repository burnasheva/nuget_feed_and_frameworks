using NUnit.Framework;

namespace DependencyFromTeamCityFeed
{
    public class FirstTestClass
    {
        [Test]
        public void TestCalculatorDependency()
        {
            Assert.Equals(3.4, Calculator.Calculator.Plus(2.0, 1.4));
        }
    }
}