using Tyuiu.skirnevskyBR.Sprint2.Task7.V7.Lib;
namespace Tyuiu.skirnevskyBR.Sprint2.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {{
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0;
            double y = -1;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
