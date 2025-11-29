using Tyuiu.RadkoVO.Sprint1.Task6.V8.Lib;

namespace Tyuiu.RadkoVO.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "abc";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "bca";
            Assert.AreEqual(wait, res);
        }
    }
}
