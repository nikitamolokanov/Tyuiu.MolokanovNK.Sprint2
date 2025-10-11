using Tyuiu.MolokanovNK.Sprint2.Task3.V19.Lib;

namespace Tyuiu.MolokanovNK.Sprint2.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 17;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 13;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -5;
            double res = ds.Calculate(x);
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -15;
            double wait = -164.933;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
