namespace BulkyBook.DataAccess.Repository
{
    using BulkyBook.Models;
    using BulkyBookWeb.Data;
    using BulkyBook.DataAccess.Repository.IRepository;

    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) 
            : base(db)
        {
            _db = db;
        }
        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
