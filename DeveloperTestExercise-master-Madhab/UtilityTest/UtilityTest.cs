using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilityTest
{
    [TestClass]
    public class UtilityTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result=Utility.Utility.IsValidPath("ddd");
            Assert.Equals(result, false);
        }
        [TestMethod]
        public void TestMethod2()
        {
            bool result = Utility.Utility.IsValidPath("c:\\test.txt");
            Assert.Equals(result, true);
        }
    }
}
