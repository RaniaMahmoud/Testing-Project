using NUnit.Framework;
using Pizza_Hut.ViewModel.ProductViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    [TestFixture]
    internal class ProductSizeViewModel_Test
    {
        ProductSizeViewModel ProductSizeViewModel;
        [SetUp]
        public void Setup()
        {
            ProductSizeViewModel = new ProductSizeViewModel();
        }
        [Test]
        public void Cart_Check_Exist_Small_Property()
        {
            Assert.That(ProductSizeViewModel, Has.Property("Small"));
        }
        [Test]
        public void Cart_Check_Exist_Medium_Property()
        {
            Assert.That(ProductSizeViewModel, Has.Property("Medium"));
        }
        [Test]
        public void Cart_Check_Exist_Large_Property()
        {
            Assert.That(ProductSizeViewModel, Has.Property("Large"));
        }
        [Test]
        public void Cart_Check_Exist_PriceSmall_Property()
        {
            Assert.That(ProductSizeViewModel, Has.Property("PriceSmall"));
        }
        [Test]
        public void Cart_Check_Exist_PriceMedium_Property()
        {
            Assert.That(ProductSizeViewModel, Has.Property("PriceMedium"));
        }
        [Test]
        public void Cart_Check_Exist_PriceLarge_Property()
        {
            Assert.That(ProductSizeViewModel, Has.Property("PriceLarge"));
        }


    }
}
