using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint4.Task6.V10.Lib;

namespace Tyuiu.HodakovaNA.Sprint4.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            var Data = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            string[] res = ds.Calculate(Data);
            string[] wait = { "Театр", "Кино", "Музей", "Парк" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
