﻿using Tyuiu.MolokanovNK.Sprint2.Task7.V6.Lib;

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

                double x = -2;
                double y = 2;

                bool res = ds.CheckDotInShadedArea(x, y);
                bool wait = true;
                Assert.AreEqual(wait, res);
            }
        }
    }
}
