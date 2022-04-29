using NUnit.Framework;
using Pizza_Hut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Hut.Test
{
    internal class CommentModelTest
    {
        Comment comment;
        [SetUp]
        public void Setup()
        {
            comment = new Comment();
        }
        [Test]
        public void Comment_Check_Exist_UserName_Property()
        {
            Assert.That(comment, Has.Property("UserName"));
        }

        [Test]
        public void Comment_Check_Exist_Comment_Property()
        {
            Assert.That(comment, Has.Property("comment"));
        }

        [Test]
        public void Comment_Check_Exist_ProductID_Property()
        {
            Assert.That(comment, Has.Property("ProductID"));
        }
    }
}
