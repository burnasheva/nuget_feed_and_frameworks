using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class FirstTest
    {
        [TestMethod]
        public void FirstTestMethod()
        {
            Assert.IsTrue(true);
        }

        [ITestMethod]
        public void SecondTestMethod()
        {
            Assert.IsFalse(false);
        }
    }
}