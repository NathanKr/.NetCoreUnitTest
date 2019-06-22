using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloUnitTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSum()
        {
            int num1=3, num2=4;
            int result = Utils.Sum(num1, num2);
            Assert.AreEqual(result, num1 + num2);
        }
    }
}
