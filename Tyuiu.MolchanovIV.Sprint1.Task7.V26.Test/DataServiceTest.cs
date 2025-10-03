using Tyuiu.MolchanovIV.Sprint1.Task7.V26.Lib;

namespace Tyuiu.MolchanovIV.Sprint1.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(2, 4);
            Assert.AreEqual(0.754, res);
        }
    }
}
