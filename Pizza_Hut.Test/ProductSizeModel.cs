using NUnit.Framework;
using Pizza_Hut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    internal class ProductSizeModel
    {
        ProductSize productSize;
        [SetUp]
        public void Setup()
        {
            productSize = new ProductSize();
        }
        [Test]
        public void productSize_Check_Exist_Size_Property()
        {
            Assert.That(productSize, Has.Property("size"));
        }

        [Test]
        public void ProductSize_Check_Exist_Price_Property()
        {
            Assert.That(productSize, Has.Property("Price"));
        }

        [Test]
        public void ProductSize_Check_Exist_ProductSizeOrders_Property()
        {
            Assert.That(productSize, Has.Property("ProductID"));
        }
    }
}
