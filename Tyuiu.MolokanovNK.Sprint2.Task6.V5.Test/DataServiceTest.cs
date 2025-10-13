﻿using Tyuiu.MolokanovNK.Sprint2.Task6.V5.Lib;

namespace Tyuiu.MolokanovNK.Sprint2.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("шестерка", ds.FindCardValue(6));
            Assert.AreEqual("семерка", ds.FindCardValue(7));
            Assert.AreEqual("восьмерка", ds.FindCardValue(8));
            Assert.AreEqual("девятка", ds.FindCardValue(9));
            Assert.AreEqual("десятка", ds.FindCardValue(10));
            Assert.AreEqual("валет", ds.FindCardValue(11));
            Assert.AreEqual("дама", ds.FindCardValue(12));
            Assert.AreEqual("король", ds.FindCardValue(13));
            Assert.AreEqual("туз", ds.FindCardValue(14));

            Assert.ThrowsException<ArgumentException>(() => ds.FindCardValue(15));
            Assert.ThrowsException<ArgumentException>(() => ds.FindCardValue(5));
        }
    }    
}
