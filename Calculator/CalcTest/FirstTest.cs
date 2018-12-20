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
            Assert.IsFalse(false);
        }

        [TestMethod]
        public void ThirdTestMethod()
        {
            Assert.AreEqual(5, 2 + 3);
        }

        [TestMethod]
        public void FourthTestMethod()
        {
            Assert.IsNull(null);
        }

        [TestMethod]
        public void FifthTestMethod()
        {
            Assert.IsNotNull(5);
        }
    }
}