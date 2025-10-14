using Tyuiu.skirnevskyBR.Sprint2.Task6.V14.Lib;
namespace Tyuiu.skirnevskyBR.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("Среда", ds.FindDayName(3, 1));
            Assert.AreEqual("Четверг", ds.FindDayName(4, 1));
            Assert.AreEqual("Пятница", ds.FindDayName(5, 1));
            Assert.AreEqual("Суббота", ds.FindDayName(6, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
            Assert.AreEqual("Понедельник", ds.FindDayName(8, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(365, 1));

            Assert.AreEqual("Воскресенье", ds.FindDayName(1, 7));
            Assert.AreEqual("Понедельник", ds.FindDayName(2, 7));
            Assert.AreEqual("Вторник", ds.FindDayName(3, 7));
            Assert.AreEqual("Среда", ds.FindDayName(4, 7));

            Assert.AreEqual("Среда", ds.FindDayName(1, 3));
            Assert.AreEqual("Четверг", ds.FindDayName(2, 3));
            Assert.AreEqual("Пятница", ds.FindDayName(3, 3));
            Assert.AreEqual("Суббота", ds.FindDayName(4, 3));

            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(365, 7));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(0, 1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(366, 1);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(10, 0);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(10, 8);
            });
        }
    }
}
