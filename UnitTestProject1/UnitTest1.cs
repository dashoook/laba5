using L51;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            L51.Course s = new Course();
           
            int m = 30;
            int[] num = {34, 40, 30, 16,30};
            int result = s.Average(num);
            Assert.AreEqual(m, result);
        }
    }
}
