using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.skirnevskyBR.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) && (c > d);           
            res[1] = (b == c) | (d >= a);            
            res[2] = (a < d) ^ (b <= c);           
            res[3] = (c == d) & (a >= b);          
            res[4] = (d > a) || (b == c);          
            res[5] = (b >= a) && (c != d);

            return res;
        }
    }
}
