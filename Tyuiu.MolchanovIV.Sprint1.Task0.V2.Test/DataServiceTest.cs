using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MolchanovIV.Sprint1.Task0.V2.Lib;

namespace Tyuiu.MolchanovIV.Sprint1.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}