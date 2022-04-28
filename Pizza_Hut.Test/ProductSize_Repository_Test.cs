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
    [TestFixture]
    public class ProductSize_Repository_Test
    {
        ProductSizeCartRepository productSizeCartRepository;
        
        [SetUp]
        public void Setup()
        {
            Context context = new Context();
            productSizeCartRepository = new ProductSizeCartRepository(context);
        }

        [Test]
        public void GetAll_productSizeCart_Test()
        {
            Assert.That(productSizeCartRepository.GetAll().Count == 1);
        }

        [Test]
        public void GetAll_productSizeCart_IsInstanceOf_Test()
        {
            Assert.IsInstanceOf<List<ProductSizeCart>>(productSizeCartRepository.GetAll());
        }

        [Test]
        public void GetById_productSizeCart_ExistObject_Test()
        {
            Assert.AreEqual(1, productSizeCartRepository.GetById(4).Quantity);
        }

        [Test]
        
        public void GetById_productSizeCart_IsInstanceOf_Test()
        {
            Assert.IsInstanceOf<ProductSizeCart>(productSizeCartRepository.GetById(4));
        }

        [Test]
        public void GetById_productSizeCart_NotExistObject_Test()
        {
            Assert.IsNull(productSizeCartRepository.GetById(1));
        }

        [Test]
        public void GetById_productSizeCart_AreSameObject_Test()
        {
            ProductSizeCart productSizeCart = new ProductSizeCart()
            {
                ID = 4,
                Quantity = 1,
                CartID = 3,
                ProductSizeID = 11,
            };
            ProductSizeCart _productSizeCart = productSizeCartRepository.GetById(4);

            Assert.That(((productSizeCart.Quantity == _productSizeCart.Quantity) 
                && (productSizeCart.CartID == _productSizeCart.CartID) 
                && (productSizeCart.ProductSizeID == _productSizeCart.ProductSizeID)));
        }

        [Test]
        public void Insert_productSizeCart_Test()
        {
            ProductSizeCart productSizeCart = new ProductSizeCart()
            {
                Quantity = 20,
                CartID=3,
                ProductSizeID=10,
            };
            Assert.AreEqual(1, productSizeCartRepository.Insert(productSizeCart));
        }

        [Test]
        public void Update_productSizeCart_Test()
        {
            ProductSizeCart productSizeCart = new ProductSizeCart()
            {
                Quantity = 10,
                CartID = 3,
                ProductSizeID = 10,
            };
            Assert.AreEqual(1, productSizeCartRepository.Update(1002,productSizeCart));
        }

        [Test]
        public void Update_productSizeCart_NotExistObject_Test()
        {
            ProductSizeCart productSizeCart = new ProductSizeCart()
            {
                Quantity = 10,
                CartID = 3,
                ProductSizeID = 10,
            };
            Assert.AreEqual(0, productSizeCartRepository.Update(1, productSizeCart));
        }

        [Test]
        public void Update_productSizeCart_NullObject_Test()
        {
            Assert.Throws<NullReferenceException>(()=>productSizeCartRepository.Update(4, null));
        }

        [Test]
        public void Delete_productSizeCart_Test()
        {
            Assert.AreEqual(1, productSizeCartRepository.Delete(1002));
        }

        [Test]
        public void Delete_productSizeCart_NotExistObject_Test()
        {
            Assert.Throws<ArgumentNullException>(() => productSizeCartRepository.Delete(12));
        }
    }
}
