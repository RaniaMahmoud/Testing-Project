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
    internal class Cart_Model
    {
        Cart cart;
        [SetUp]
        public void Setup()
        {
            cart = new Cart();
        }
        [Test]
        public void Cart_Check_Exist_TotalPrice_Property()
        {
            Assert.That(cart, Has.Property("TotalPrice"));
        }
        [Test]
        public void Cart_Check_Exist_CustomerID_Property()
        {
            Assert.That(cart, Has.Property("CustomerID"));
        }
       
    }
}
