namespace BulkyBook.DataAccess.Repository.IRepository
{
    using BulkyBook.Models;

    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        void Update(OrderDetail obj);
    }
}
