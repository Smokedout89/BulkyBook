namespace BulkyBook.DataAccess.Repository.IRepository
{
    using BulkyBook.Models;

    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
    }
}
