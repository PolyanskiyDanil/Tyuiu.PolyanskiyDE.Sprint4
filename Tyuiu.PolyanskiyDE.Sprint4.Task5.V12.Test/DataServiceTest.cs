using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint4.Task5.V12.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 1, -4, -6, 2, -5 },
                                           { -5, 3, -5, 4, -6 },
                                           { -4, 5, -2, 4, 3 },
                                           { -3, 3, -3, 4, 2 },
                                           { -5, 0, 0, 1, 2 } };
            int res = ds.Calculate(matrix);
            int wait = 11;
            Assert.AreEqual(wait, res);
        }
    }
}
