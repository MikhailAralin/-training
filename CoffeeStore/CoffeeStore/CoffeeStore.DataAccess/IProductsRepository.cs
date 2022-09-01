using CoffeeStore.DataAccess.Models;

namespace CoffeeStore.DataAccess
{
    internal interface IProductsRepository
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
