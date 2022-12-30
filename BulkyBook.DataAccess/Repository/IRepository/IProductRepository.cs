namespace BulkyBook.DataAccess.Repository.IRepository
{
    using BulkyBook.Models;

    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
