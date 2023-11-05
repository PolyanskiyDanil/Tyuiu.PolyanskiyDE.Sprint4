using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint4.Task2.V8.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 2, 6, 5, 4, 6, 5, 2, 3, 2 };

            int res = ds.Calculate(array);
            int wait = 16;

            Assert.AreEqual(wait, res);
        }
    }
}
