namespace BulkyBook.DataAccess.Repository.IRepository
{
    using BulkyBook.Models;

    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType obj);
    }
}
