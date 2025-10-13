using Tyuiu.MolokanovNK.Sprint2.Task5.V15.Lib;
namespace Tyuiu.MolokanovNK.Sprint2.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDay()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.FindDayName(x);
            Assert.AreEqual("Понедельник", res);
        }
    }
    
}
