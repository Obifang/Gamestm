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
    public class SalesClassTests
    {
        [TestMethod()]
        public void SalesClassTest()
        {
            //are the values set
            //can values intended to change be edited

            //StockItems
            //Assign price to stock item
            //Have stock data in messages

            //StockCount
            //Add item - does count increase
            //Multiple items - is purchase price totalled

            //SalesDate
            //Is timestamp correct

            //StockSold
            //Do sales contribute to total stock sold
            //Is the sales total (price) calculated

            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateStockTest()
        {
            //Adding stock should increase stock value
            //Stock should retain individual values; name, desc, price, id

            Assert.Fail();
        }

        [TestMethod()]
        public void AddStockToSaleTest()
        {
            //Stock should be added to sale
            //Total calculated
            //Values of stock changed to reflect sale/loss

            Assert.Fail();
        }
    }
}