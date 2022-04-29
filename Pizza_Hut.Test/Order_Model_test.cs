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
    internal class Order_Model_test
    {
        Order order;
        [SetUp]
        public void Setup()
        {
            order = new Order();
        }
        [Test]
        public void Cart_Check_Exist_TotalPrice_Property()
        {
            Assert.That(order, Has.Property("TotalPrice"));
        }
        [Test]
        public void Cart_Check_Exist_CustomerID_Property()
        {
            Assert.That(order, Has.Property("CustomerID"));
        }
        [Test]
        public void Cart_Check_Exist_Date_Property()
        {
            Assert.That(order, Has.Property("Date"));
        }
        [Test]
        public void Cart_Check_Exist_Location_Property()
        {
            Assert.That(order, Has.Property("Location"));
        }

    }
}
