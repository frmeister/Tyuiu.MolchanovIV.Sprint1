using Tyuiu.MolchanovIV.Sprint1.Task6.V3.Lib;

namespace Tyuiu.MolchanovIV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.LastLetterWord("haha ahah haha ahah");
            Assert.AreEqual("ahah", res);
        }
    }
}
