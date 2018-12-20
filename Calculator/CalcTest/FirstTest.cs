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
            Assert.IsNull(4);
        }

        [TestMethod]
        public void FifthTestMethod()
        {
            Assert.IsNotNull(null);
            
        }

        [TestMethod]
        public void MoreTests()
        {
            Assert.IsNull(null);
        }

        [TestMethod]
        public void TestShouldFail()
        {
            Assert.IsNotNull(null);
        }
    }
}