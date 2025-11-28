using Tyuiu.RadkoVO.Sprint1.Task4.V15.Lib;

namespace Tyuiu.RadkoVO.Sprint1.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 1;
            double walt = 44.334;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(walt, res);
        }
    }
}
