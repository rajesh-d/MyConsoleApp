using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyConsoleApp;


namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Jenkin Test",Program.Display());
        }
    }
}
