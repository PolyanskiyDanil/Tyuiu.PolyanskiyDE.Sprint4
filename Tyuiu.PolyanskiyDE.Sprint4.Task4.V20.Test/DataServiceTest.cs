using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint4.Task4.V20.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint4.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                           { 5, 5, 5, 4, 6 },
                                           { 8, 5, 7, 4, 7 },
                                           { 7, 6, 7, 4, 7 },
                                           { 5, 8, 7, 8, 8 } };

            int[,] res = ds.Calculate(matrix);
           
            int[,] wait = new int[5, 5] { { 5, 7, 1, 1, 5 },
                                           { 5, 5, 5, 1, 1 },
                                           { 1, 5, 7, 1, 7 },
                                           { 7, 1, 7, 1, 7 },
                                           { 5, 1, 7, 1, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
