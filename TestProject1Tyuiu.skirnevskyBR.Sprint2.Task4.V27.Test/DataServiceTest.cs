using Tyuiu.skirnevskyBR.Sprint2.Task4.V27.Lib;
namespace TestProject1Tyuiu.skirnevskyBR.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 100;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 24.98;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 128.625;
            Assert.AreEqual(wait, res);
        }
    }
}