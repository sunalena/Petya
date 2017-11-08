using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Program();
            var r = p.funkch(1, 2, 3);
            Assert.AreEqual(r, false);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestMethod2()
        {
            var p = new Program();
            var r = p.funkch(0, 2, 3);

        }
        [TestMethod]
        public void TestMethod3()
        {
            var p = new Program();
            var r = p.funkch(1, 2, 3);
            Assert.IsFalse(r);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var p = new Program();
            var r = p.funkch(1, 2, 3);
            Assert.IsTrue(!r);
        }
    }
}
