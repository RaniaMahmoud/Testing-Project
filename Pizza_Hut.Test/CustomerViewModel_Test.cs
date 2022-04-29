using NUnit.Framework;
using Pizza_Hut.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    [TestFixture]
    internal class CustomerViewModel_Test
    {
        CustomerViewModel CustomerViewModel;
        [SetUp]
        public void Setup()
        {
            CustomerViewModel = new CustomerViewModel();
        }
        [Test]
        public void CustomerViewModel_Check_Exist_UserName_Property()
        {
            Assert.That(CustomerViewModel, Has.Property("UserName"));
        }
        [Test]
        public void CustomerViewModel_Check_Exist_Address_Property()
        {
            Assert.That(CustomerViewModel, Has.Property("  Address "));
        }
        [Test]
        public void CustomerViewModel_Check_Exist_PhoneNumber_Property()
        {
            Assert.That(CustomerViewModel, Has.Property("PhoneNumber"));
        }
    }
}
