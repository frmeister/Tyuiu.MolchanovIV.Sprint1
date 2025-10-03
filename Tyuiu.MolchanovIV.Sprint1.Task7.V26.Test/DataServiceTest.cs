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
            var res = ds.Calculate(30, 60);
            Assert.AreEqual(1, res);
        }
    }
}
