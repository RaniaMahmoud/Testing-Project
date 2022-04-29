using Microsoft.EntityFrameworkCore;
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
    public class CartRepoTest
    {
        CartRepository cartRepository;
        Context context;

        [SetUp]
        public void Setup()
        {
            context = new Context();
            cartRepository = new CartRepository(context);
        }

        [Test]
        public void all()

        {
             
            Assert.IsNotNull(cartRepository.GetAll());
        }
        [Test]
        public void GetCartByID()

        {
            Assert.IsNotNull(cartRepository.GetById(3));
        }
        [Test]
        public void InsertCart()
        {
            Cart cart = new Cart() { CustomerID = "7a83bf399332", TotalPrice = 300 };
            Assert.Throws<DbUpdateException>(() =>
            {
                var res = cartRepository.Insert(cart);
            });
            //Assert.That(res,Is.EqualTo(0));
        }
        [Test]
        public void Update()
        {
            Cart cart = new Cart() {  TotalPrice = 200 };
            var res = cartRepository.Update(3,cart);
            Assert.That(res, Is.EqualTo(1));
        }
    }
}
