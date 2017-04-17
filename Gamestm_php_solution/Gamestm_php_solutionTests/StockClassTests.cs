using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gamestm_php_solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamestm_php_solution.Tests
{
    [TestClass()]
    public class StockClassTests
    {
        [TestMethod()]
        public void editNameTest()
        {
            StockClass testStock = new StockClass("stock name", "stock desc", 1, 2, 3);
            Assert.AreEqual(testStock.GetName, "stock name");

            testStock.edit("new name", "new desc", 4, 5);
            Assert.AreEqual(testStock.GetName, "new name");

            //Assert.Fail();
        }
        [TestMethod()]
        public void editDescTest()
        {
            StockClass testStock = new StockClass("stock name", "stock desc", 1, 2, 3);
            Assert.AreEqual(testStock.GetDesc, "stock desc");

            testStock.edit("new name", "new desc", 4, 5);
            Assert.AreEqual(testStock.GetDesc, "new desc");

            //Assert.Fail();
        }
        [TestMethod()]
        public void editIdTest()
        {
            StockClass testStock = new StockClass("stock name", "stock desc", 1, 2, 3);
            Assert.AreEqual(testStock.GetId, 1);

            testStock.edit("new name", "new desc", 4, 5);
            Assert.AreEqual(testStock.GetId, 4);

            //Assert.Fail();
        }
        [TestMethod()]
        public void editPriceTest()
        {
            StockClass testStock = new StockClass("stock name", "stock desc", 1, 2, 3);
            Assert.AreEqual(testStock.GetPrice, 2);

            testStock.edit("new name", "new desc", 4, 5);
            Assert.AreEqual(testStock.GetPrice, 5);

            //Assert.Fail();
        }
    }
}