using NUnit.Framework;
using Pizza_Hut.Models;
using Pizza_Hut.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    internal class ProductSizeOrderTest
    {
        ProductSizeOrderRepository productSizeOrderRepository ;

        [SetUp]
        public void Setup()
        {
            Context context = new Context();
            productSizeOrderRepository = new ProductSizeOrderRepository(context);
        }
        [Test]
        public void GetAll_Test()
        {
            Assert.That(productSizeOrderRepository.GetAll().Count > 1);
        }

        [Test]
        public void GetAll_productSizeOrder_IsInstanceOfTest()
        {
            Assert.IsInstanceOf<List<ProductSizeOrder>>(productSizeOrderRepository.GetAll());
        }

        [Test]
        public void GetById_productSizeOrder_ExistObject_Test()
        {
            Assert.AreEqual(1, productSizeOrderRepository.GetById(4).Quantity);
        }

        [Test]

        public void GetById_productSizeOrder_IsInstanceOf_Test()
        {
            Assert.IsInstanceOf<ProductSizeOrder>(productSizeOrderRepository.GetById(4));
        }

        [Test]
        public void GetById_productSizeOrder_NotExistObject_Test()
        {
            Assert.IsNull(productSizeOrderRepository.GetById(1));
        }

        [Test]
        public void Update_productSizeCart_NullObject_Test()
        {
            Assert.Throws<NullReferenceException>(() => productSizeOrderRepository.Update(4, null));
        }

        [Test]
        public void Delete_productSizeOrder_Test()
        {
            Assert.AreEqual(0, productSizeOrderRepository.Delete(0));
        }
    }
}
