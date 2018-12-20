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

        [TestMethod]
        public void SecondTestMethod()
        {
            Assert.IsFalse(true);
        }

        [TestMethod]
        public void ThirdTestMethod()
        {
            Assert.AreEqual(5, 2 + 3);
        }
    }
}