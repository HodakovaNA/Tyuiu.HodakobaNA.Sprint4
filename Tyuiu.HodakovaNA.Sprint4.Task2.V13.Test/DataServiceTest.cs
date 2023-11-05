using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint4.Task2.V13.Lib;

namespace Tyuiu.HodakovaNA.Sprint4.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 4, 4, 7, 2, 5, 4, 3, 3, 4, 1, 3, 5 };
           
            Assert.AreEqual(ds.Calculate(numsArray), 1024);
        }
    }
}
