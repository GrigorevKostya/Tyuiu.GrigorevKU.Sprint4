using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint4.Task0.V25.Lib;
namespace Tyuiu.GrigorevKU.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
            int wait = 42;
            int res = ds.GetSumEvenArrEl(numsArray);
            Assert.AreEqual(wait, res);

        }
    }
}
