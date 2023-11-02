using ShoppingDALLibrary;
using ShoppingModelLibrary;

namespace DALTest
{
    public class ProductRepositoryTest
    {
        IRepository<int,Product> _repository;
        [SetUp]
        public void Setup()
        {
            _repository =  new ProductRepository();
        }

        [Test]
        public void AddProductTest()
        {
            //Arrange

            //Action
            var result = _repository.Add(new Product { Id = 100, Name = "Pencil" });
            //Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void GetAllProductsTest()
        {
            //Arrange
            var prod = _repository.Add(new Product { Id = 100, Name = "Pencil" });
            //Action
            var result = _repository.GetAll();
            //Assert
            Assert.AreEqual(1,result.Count);
        }
        [TestCase(1,"Pencil")]
        [TestCase(2, "Pen")]
        public void GetProductTest(int id,string name)
        {
            //Arrange
            var prod = _repository.Add(new Product {  Name = "Pencil" });
            //Action
            var result = _repository.GetById(1);
            //Assert
            //Assert.AreEqual(id, result.Id);//Old
            Assert.That(result.Id, Is.EqualTo(id));
        }
    }
}