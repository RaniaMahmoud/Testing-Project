using NUnit.Framework;
using Pizza_Hut.Repository;

namespace Pizza_Hut.Test
{
    public class Tests
    {
        CategoryRepository categoryRepository;
        [SetUp]
        public void Setup()
        {
            categoryRepository = new CategoryRepository();
        }

        [Test]
        public void Test1()
        {
            Assert.IsNotNull(categoryRepository.GetAll());
        }
    }
}