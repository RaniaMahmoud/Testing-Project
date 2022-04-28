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
    [TestFixture]
    public class Comment_Repository_Test
    {
        CommentRepository commentRepository;
        [SetUp]
        public void Setup()
        {
            Context context = new Context();
            commentRepository = new CommentRepository(context);
        }

        [Test]
        public void GetAll_Comments_Test()
        {
            Assert.IsNotNull(commentRepository.GetAll());
        }
        
        [Test]
        public void GetAll_Comments_ReturnType_Test()
        {
            List<Comment> comments = new List<Comment>();
            comments = commentRepository.GetAll();
            Assert.IsInstanceOf<List<Comment>>(comments);
        }

        [Test]
        public void Delete_Comments_Test()
        {
            int RowEffect = commentRepository.Delete(0);
            Assert.Zero(RowEffect);
        }
        
        [Test]
        public void Delete_Comments_NegativeID_Test()
        {
            int RowEffect = commentRepository.Delete(-10);
            Assert.Zero(RowEffect);
        }

        [Test]
        public void Delete_Comments_StringLetter_Test()
        {
            Assert.Throws<FormatException>(()=>commentRepository.Delete(int.Parse("a")));
        }

        [Test]
        public void Delete_Comments_StringNumber_Test()
        {
            Assert.Zero(commentRepository.Delete(int.Parse("1")));
        }

        [Test]
        public void Delete_Comments_StringEmpty_Test()
        {
            Assert.Throws<FormatException>(() => commentRepository.Delete(int.Parse("")));
        }

        [Test]
        public void Delete_Comments_LargeNumber_Test()
        {
            Assert.Throws<OverflowException>(() => commentRepository.Delete(int.Parse("1000000000000000")));
        }

        [Test]
        public void GetById_Comments_Test()
        {
            Assert.IsNull(commentRepository.GetById(0));
        }

        [Test]
        public void GetById_Comments_NegativeNumber_Test()
        {
            Assert.IsNull(commentRepository.GetById(-1));
        }
        
        [Test]
        public void Insert_Comments_Test()
        {
            Comment comment = new Comment()
            {
                comment = "Comment",
                ProductID = 11,
                UserName = "User1"
            };
            Assert.AreEqual(1, commentRepository.Insert(comment));
        }

        [Test]
        public void Insert_Comments_NoTExistProduct_Test()
        {
            Comment comment = new Comment()
            {
                comment = "Comment",
                ProductID = 1,
                UserName = "User1"
            };
            Assert.That(commentRepository.Insert(comment) == 0);
        }

        [Test]
        public void Insert_Comments_EmptyObject_Test()
        {
            Comment comment = new Comment();
            Assert.That(commentRepository.Insert(comment) == 0);
        }

        [Test]
        public void Insert_Comments_MissingProperty_Test()
        {
            Comment comment = new Comment()
            {
                UserName = "USerTwo",
                comment = "Comment"
            };
            Assert.That(commentRepository.Insert(comment) == 0);
        }

        [Test]
        public void Update_Comments_Test()
        {
            Comment comment = new Comment()
            {
                UserName = "UserEdited",
                comment = "Comment",
                ProductID = 11
            };
            Assert.AreEqual(1,commentRepository.Update(35,comment));
        }

        [Test]
        public void Update_Comments_UnExistingComment_Test()
        {
            Comment comment = new Comment()
            {
                UserName = "UserEdited",
                comment = "Comment",
                ProductID = 11
            };
            Assert.AreEqual(0, commentRepository.Update(0, comment));
        }

        [Test]
        public void Update_Comments_UpdateToUnExistProduct_Test()
        {
            Comment comment = new Comment()
            {
                UserName = "UserEdited",
                comment = "Comment",
                ProductID = 1
            };
            Assert.AreEqual(0, commentRepository.Update(0, comment));
        }

        [Test]
        public void Update_Comments_MissingObjectData_Test()
        {
            Comment comment = new Comment()
            {
                UserName = "UserEdited",
            };
            Assert.AreEqual(0, commentRepository.Update(0, comment));
        }

        [Test]
        public void GetById_Comments_ExistComment_Test()
        {
            Assert.IsNotNull(commentRepository.GetById(35));
        }

        [Test]
        public void GetAll_Comments_ExistComment_Test()
        {
            Assert.That(commentRepository.GetAll(), Is.Not.Null);
        }

        [Test]
        public void Delete_Comments_ExistComment_Test()
        {
            int RowEffect = commentRepository.Delete(35);
            Assert.That(RowEffect == 1);
        }
    }
}
