using NUnit.Framework;
using Pizza_Hut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    public class CustomerModelTest
    {
        Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }
        [Test]
        public void HasId()
        {
            Assert.That(customer, Has.Property("Id"));
        }
        [Test]
        public void HasAddress()
        {
            Assert.That(customer, Has.Property("Address"));
        }
        
        
        [Test]
        public void HasCartID()
        {
            Assert.That(customer, Has.Property("CartID"));
        }
        [Test]
        public void HasUserName()
        {
            Assert.That(customer, Has.Property("UserName"));
        }
        [Test]
        public void HasNormalizedUserName()
        {
            Assert.That(customer, Has.Property("NormalizedUserName"));
        }
        [Test]
        public void HasEmail()
        {
            Assert.That(customer, Has.Property("Email"));
        }
        [Test]
        public void HasNormalizedEmail()
        {
            Assert.That(customer, Has.Property("NormalizedEmail"));
        }
        [Test]
        public void HasEmailConfirmed()
        {
            Assert.That(customer, Has.Property("EmailConfirmed"));
        }
        [Test]
        public void HasPasswordHash()
        {
            Assert.That(customer, Has.Property("PasswordHash"));
        }
        [Test]
        public void HasSecurityStamp()
        {
            Assert.That(customer, Has.Property("SecurityStamp"));
        }
        [Test]
        public void HasConcurrencyStamp()
        {
            Assert.That(customer, Has.Property("ConcurrencyStamp"));
        }
        [Test]
        public void HasPhoneNumber()
        {
            Assert.That(customer, Has.Property("PhoneNumber"));
        }
        [Test]
        public void HasPhoneNumberConfirmed()
        {
            Assert.That(customer, Has.Property("PhoneNumberConfirmed"));
        }
        [Test]
        public void HasTwoFactorEnabled()
        {
            Assert.That(customer, Has.Property("TwoFactorEnabled"));
        }
        [Test]
        public void HasLockoutEnd()
        {
            Assert.That(customer, Has.Property("LockoutEnd"));
        }
        [Test]
        public void HasLockoutEnabled()
        {
            Assert.That(customer, Has.Property("LockoutEnabled"));
        }
        [Test]
        public void HasAccessFailedCount()
        {
            Assert.That(customer, Has.Property("AccessFailedCount"));
        }





    }
}
