namespace BulkyBook.DataAccess.Repository.IRepository
{
    using BulkyBook.Models;

    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        int IncrementCount(ShoppingCart shoppingCart, int count);
        int DecrementCount(ShoppingCart shoppingCart, int count);
    }
}
