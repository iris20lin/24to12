using System;
using _1080109_24timeto124;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace time24to12
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 是不是24()
        {
            Class1 program = new Class1();
            string inp = "13:45";
                string ex = "1:45PM";
            string act = program.MilitaryTimeToRegularTime(inp);
            Assert.AreEqual(ex,act);
        }

        [TestMethod]
        public void 是不是1200()
        {
            Class1 program = new Class1();
            string inp = "12:00";
            string ex = "12:00PM";
            string act = program.MilitaryTimeToRegularTime(inp);
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void 是不是0000()
        {
            Class1 program = new Class1();
            string inp = "00:00";
            string ex = "12:00AM";
            string act = program.MilitaryTimeToRegularTime(inp);
            Assert.AreEqual(ex, act);
        }
    }
}
