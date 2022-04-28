﻿using NUnit.Framework;
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
    public class Category_Model_Test
    {
        Category category;
        [SetUp]
        public void Setup()
        {
            category = new Category();
        }

        [Test]
        public void Category_Check_Exist_Name_Property()
        {
            Assert.That(category, Has.Property("Name"));
        }

        [Test]
        public void Category_Check_Exist_Description_Property()
        {
            Assert.That(category, Has.Property("Description"));
        }

        [Test]
        public void Category_Check_Exist_Image_Property()
        {
            Assert.That(category, Has.Property("Image"));
        }
    }
}
