using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6_1;


namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia_0()
        {
            Silnia silnia = new Silnia();
            silnia.SetLiczba(0);
            Assert.AreEqual(silnia.Result(), 1);
        }

        [TestMethod]
        public void Silnia_1()
        {
            Silnia silnia = new Silnia();
            silnia.SetLiczba(1);
            Assert.AreEqual(silnia.Result(), 1);
        }
        [TestMethod]
        public void Silnia_5()
        {
            Silnia silnia = new Silnia();
            silnia.SetLiczba(5);
            Assert.AreEqual(silnia.Result(), 120);
        }
    }
}
