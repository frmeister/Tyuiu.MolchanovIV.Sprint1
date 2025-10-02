using Tyuiu.MolchanovIV.Sprint1.Task5.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(1.37);
            Assert.AreEqual(3, res);
        }
    }
}
