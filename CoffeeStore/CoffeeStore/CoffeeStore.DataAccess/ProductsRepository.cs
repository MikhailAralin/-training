using CoffeeStore.DataAccess.Models;

namespace CoffeeStore.DataAccess
{
    internal class ProductsRepository : IProductsRepository
    {
        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
