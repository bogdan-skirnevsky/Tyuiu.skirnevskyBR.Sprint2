using Tyuiu.skirnevskyBR.Sprint2.Task1.V15.Lib;
namespace Tyuiu.skirnevskyBR.Sprint2.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 415;
            int b = 616;
            int c = 134;
            int d = 127;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, false, false, false, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
