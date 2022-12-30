namespace BulkyBook.DataAccess.Repository
{
    using BulkyBook.Models;
    using BulkyBookWeb.Data;
    using BulkyBook.DataAccess.Repository.IRepository;

    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) 
            : base(db)
        {
            _db = db;
        }
        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
