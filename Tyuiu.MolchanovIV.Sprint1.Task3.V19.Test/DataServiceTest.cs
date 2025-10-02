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

            var res = ds.ElephCanMove(1,3,1,2);
            Assert.IsTrue(res);
        }
    }
}
