using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoeTesting
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class that we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see if it exists 
            Assert.IsNotNull(AnOrder);
        }
    }
}
