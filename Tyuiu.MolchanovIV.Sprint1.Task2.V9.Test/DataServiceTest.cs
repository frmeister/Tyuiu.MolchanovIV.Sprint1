using Tyuiu.MolchanovIV.Sprint1.Task2.V9.Lib;

namespace Tyuiu.MolchanovIV.Sprint1.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateVolumeCircle(x);
            Assert.AreEqual(-1, res);
        }
    }
}
