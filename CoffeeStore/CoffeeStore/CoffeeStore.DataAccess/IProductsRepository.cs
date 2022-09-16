using CoffeeStore.DataAccess.Dto;

namespace CoffeeStore.DataAccess
{
    public interface IProductsRepository
    {
        Task<Product[]> GetAllProducts();

        Task<Product[]> GetProductsByPartialName(string partialName);

        Task<Product[]> GetProductsByType(Guid productTypeId);
    }
}
