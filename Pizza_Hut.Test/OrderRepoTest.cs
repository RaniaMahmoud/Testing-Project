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
    public class OrderRepoTest
    {
        OrderRepository order;
        Context context;
        
        [SetUp]
        public void Setup()
        {
            context = new Context();
            order = new OrderRepository(context);
        }
        [Test]
        public void GetAll()
        {
            Assert.IsNotNull( order.GetAll());
        }
        [Test]
        public void GetByID()
        {
            Assert.IsNotNull(order.GetById(4));
        }
        [Test]
        public void Insert()
        {

            Order Neworder = new Order() { CustomerID = "7", Location = "sohag", TotalPrice = 500 };
            Assert.Throws<DbUpdateException>(() =>
            {
                var res = order.Insert(Neworder);
            });
            
        }
        [Test]
        public void Delete()
        {

            Assert.That(order.Delete(9), Is.EqualTo(1));

        }


    }
}
