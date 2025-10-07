using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolokanovNK.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + 0 == b) | (c + 82 == d);
            res[1] = (c != d) & (a + 1 != b);
            res[2] = (d < b) && (a==b);
            res[3] = (a - 2 > b) || (c + 100 < d);
            res[4] = !res[3];
            res[5] = (a > b) ^ (c < d);
        }
    }
}
