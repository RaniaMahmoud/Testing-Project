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
    internal class CustomerRepositoryTest
    {
        CustomerRepository customerRepository;
        [SetUp]
        public void Setup()
        {
            Context context = new Context();
            customerRepository = new CustomerRepository(context);
        }
        [Test]
        public void GetById_Customer_Test()
        {
            Assert.IsNull(customerRepository.GetById("1"));
        }
        [Test]
        public void GetById_String_Value_Test()
        {
            Assert.IsNull(customerRepository.GetById("ff"));
        }
        
    }
}
