using Tyuiu.MolokanovNK.Sprint2.Task7.V6.Lib;

namespace Tyuiu.MolokanovNK.Sprint2.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                DataService ds = new DataService();

                double x = 1.5;
                double y = 1;

                bool res = ds.CheckDotInShadedArea(x, y);
                bool wait = true;
                Assert.AreEqual(wait, res);
            }
        }
    }
}
