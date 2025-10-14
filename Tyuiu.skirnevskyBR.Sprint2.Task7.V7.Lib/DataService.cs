using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.skirnevskyBR.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((x >= 0) && (x * x + y * y <= 1) && (y <= 0) && (y <= x / 2.0))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
