using NUnit.Framework;
using Pizza_Hut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    [TestFixture]
    public class Product_Model_Test
    {
        Product product;
        [SetUp]
        public void Setup()
        {
            product = new Product();
        }

        [Test]
        public void product_Check_Exist_Name_Property()
        {
            Assert.That(product, Has.Property("Name"));
        }

        [Test]
        public void product_Check_Exist_Description_Property()
        {
            Assert.That(product, Has.Property("Description"));
        }

        [Test]
        public void product_Check_Exist_Category_Property()
        {
            Assert.That(product, Has.Property("Category"));
        }
    }
}
