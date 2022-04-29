using NUnit.Framework;
using Pizza_Hut.Views.ViewModel.ProductViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    [TestFixture]
    internal class ProductViewModel_Test
    {

        ProductViewModel ProductViewModel;
        [SetUp]
        public void Setup()
        {
            ProductViewModel = new ProductViewModel();
        }
        [Test]
        public void Cart_Check_Exist_Name_Property()
        {
            Assert.That(ProductViewModel, Has.Property("Name"));
        }
        [Test]
        public void Cart_Check_Exist_Description_Property()
        {
            Assert.That(ProductViewModel, Has.Property("Description"));
        }
        [Test]
        public void Cart_Check_Exist_ProductImage_Property()
        {
            Assert.That(ProductViewModel, Has.Property("ProductImage"));
        }
       
        [Test]
        public void Cart_Check_Exist_Small_Property()
        {
            Assert.That(ProductViewModel, Has.Property("Small"));
        }
        [Test]
        public void Cart_Check_Exist_Medium_Property()
        {
            Assert.That(ProductViewModel, Has.Property("Medium"));
        }
        [Test]
        public void Cart_Check_Exist_Large_Property()
        {
            Assert.That(ProductViewModel, Has.Property("Large"));
        }
        [Test]
        public void Cart_Check_Exist_PriceSmall_Property()
        {
            Assert.That(ProductViewModel, Has.Property("PriceSmall"));
        }
        [Test]
        public void Cart_Check_Exist_PriceMedium_Property()
        {
            Assert.That(ProductViewModel, Has.Property("PriceMedium"));
        }
        [Test]
        public void Cart_Check_Exist_PriceLarge_Property()
        {
            Assert.That(ProductViewModel, Has.Property("PriceLarge"));
        }


    }
}

