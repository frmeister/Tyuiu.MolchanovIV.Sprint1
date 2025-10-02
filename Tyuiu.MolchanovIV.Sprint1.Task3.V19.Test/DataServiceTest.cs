using Tyuiu.MolchanovIV.Sprint1.Task3.V19.Lib;

namespace Tyuiu.MolchanovIV.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.ElephCanMove(5,1,5,1);
            Assert.IsTrue(res);
        }
    }
}
