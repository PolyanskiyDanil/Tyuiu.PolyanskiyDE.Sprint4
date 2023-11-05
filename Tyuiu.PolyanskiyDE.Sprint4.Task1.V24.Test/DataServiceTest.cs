using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint4.Task1.V24.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint4.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 2, 2, 2, 5, 5, 3, 4, 2, 5, 2, 5, 3, 4, 3, 5, 2 };
            int res = ds.Calculate(array);
            int wait = 84375;
            Assert.AreEqual(wait, res);
        }
    }
}
