using Tyuiu.RadkoVO.Sprint1.Task5.V3.Lib;

namespace Tyuiu.RadkoVO.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 156678;
            DataService ds = new DataService();
            int res = ds.Calculate(k);

            int wait = 6;
            Assert.AreEqual(wait, res);

        }
    }
}
