using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core;
using Core.Model;

namespace UnitTest1
{
    [TestClass]
    public class TestBook
    {
        [TestMethod]
        public void BookPriceWithBasicTax()
        {
            Book book = new Book(false);
            book.Price = 10.00m;
            decimal expectedpricewithtax = 10.00m;
            Assert.AreEqual(expectedpricewithtax, book.PriceWithTax);
        }
        [TestMethod]
        public void BookPriceWithBasicAndImportTax()
        {
            Book book = new Book(true);
            book.Price = 10.00m;
            decimal expectedpricewithtax = 10.50m;
            Assert.AreEqual(expectedpricewithtax, book.PriceWithTax);
        }
        [TestMethod]
        public void MusicCDPriceImported()
        {
            MusicCD musiccd = new MusicCD(true);
            musiccd.Price = 10.00m;
            decimal expectedpricewithtax = 11.50m;
            Assert.AreEqual(expectedpricewithtax, musiccd.PriceWithTax);
        }
        [TestMethod]
        public void TaxRounding()
        {
            Tax tax = new Tax();
            tax.BaseTaxRate = 33.33m;
            tax.Price = 1.00m;
            decimal expectedprice = 0.35m;
            Assert.AreEqual(expectedprice, tax.BaseTaxValue);
        }

    }
}
