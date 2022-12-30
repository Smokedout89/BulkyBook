namespace BulkyBook.DataAccess.Repository.IRepository
{
    using BulkyBook.Models;

    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}
