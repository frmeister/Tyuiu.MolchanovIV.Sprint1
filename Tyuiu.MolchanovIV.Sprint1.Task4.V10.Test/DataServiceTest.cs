using Tyuiu.MolchanovIV.Sprint1.Task4.V10.Lib;

namespace Tyuiu.MolchanovIV.Sprint1.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(60.0);
            Assert.AreEqual(2, res);
        }
    }
}
