using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorevKU.Sprint4.Task7.V16.Lib;
namespace Tyuiu.GrigorevKU.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 5;
            int m = 3;
            int[,] matrix = new int[n, m];
            string str = "382976421897948";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 196608;
            Assert.AreEqual(wait, res);
        }
    }
}
