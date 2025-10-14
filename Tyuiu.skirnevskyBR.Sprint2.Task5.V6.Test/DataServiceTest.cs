using Tyuiu.skirnevskyBR.Sprint2.Task5.V6.Lib;
namespace Tyuiu.skirnevskyBR.Sprint2.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindCardNameAndValue()
        {
            DataService ds = new DataService();

            // Проверка мастей и достоинств
            Assert.AreEqual("Шестерка пик", ds.FindCardNameAndValue(1, 6));
            Assert.AreEqual("Семерка треф", ds.FindCardNameAndValue(2, 7));
            Assert.AreEqual("Восьмерка бубен", ds.FindCardNameAndValue(3, 8));
            Assert.AreEqual("Девятка черв", ds.FindCardNameAndValue(4, 9));
            Assert.AreEqual("Десятка пик", ds.FindCardNameAndValue(1, 10));

            // Проверка карт с фигурными названиями
            Assert.AreEqual("Валет треф", ds.FindCardNameAndValue(2, 11));
            Assert.AreEqual("Дама бубен", ds.FindCardNameAndValue(3, 12));
            Assert.AreEqual("Король черв", ds.FindCardNameAndValue(4, 13));
            Assert.AreEqual("Туз пик", ds.FindCardNameAndValue(1, 14));

            // Проверка исключений для неверных мастей
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(0, 10);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(5, 10);
            });

            // Проверка исключений для неверных достоинств
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(1, 5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardNameAndValue(1, 15);
            });
        }
    }
}