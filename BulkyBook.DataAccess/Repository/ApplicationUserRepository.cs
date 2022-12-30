namespace BulkyBook.DataAccess.Repository
{
    using BulkyBook.Models;
    using BulkyBookWeb.Data;
    using BulkyBook.DataAccess.Repository.IRepository;

    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) 
            : base(db)
        {
            _db = db;
        }
    }
}
