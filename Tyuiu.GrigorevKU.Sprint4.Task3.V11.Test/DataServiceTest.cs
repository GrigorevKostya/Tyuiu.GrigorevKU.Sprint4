using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint4.Task3.V11.Lib;
namespace Tyuiu.GrigorevKU.Sprint4.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[3, 3] { { 1, 3, 0 }, { 2, 4, 6 }, { 4, 3, 2 } };

            int res = ds.Calculate(mas2);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
