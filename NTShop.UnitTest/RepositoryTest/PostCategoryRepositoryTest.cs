using Microsoft.VisualStudio.TestTools.UnitTesting;
using NTShop.Data.Infrastructure;
using NTShop.Data.Reponsitories;
using NTShop.Model.Models;
using System.Linq;

namespace NTShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(2, list.Count);
        }
        
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }
    }
}