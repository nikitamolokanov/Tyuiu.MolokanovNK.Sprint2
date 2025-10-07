using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolokanovNK.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c < d); //t +
            res[1] = (a + 2 > b) & (c == d + 1); //f + 
            res[2] = (a == b) || (c < d); //t + 
            res[3] = !res[2]; //f +
            res[4] = (a + 0 == b) && (c < d + 1); //t + 
            res[5] = (a < b) ^ (c > d); //f +

            return res;
            
        }
    }
}
