using Tyuiu.MolokanovNK.Sprint2.Task4.V16.Lib;

namespace Tyuiu.MolokanovNK.Sprint2.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 1.562;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 15.504;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }

    }
}
