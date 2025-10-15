using Tyuiu.skirnevskyBR.Sprint2.Task0.V11.Lib;
namespace Tyuiu.skirnevskyBR.Sprint2.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCompareOperations()
        {
            DataService ds = new DataService();
            int x = 8105;
            int y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
