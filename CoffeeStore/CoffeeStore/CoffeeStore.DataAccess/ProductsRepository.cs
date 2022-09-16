using CoffeeStore.DataAccess.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CoffeeStore.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        private CoffeeStoreContext _dbContext = new();

        public Task<Product[]> GetAllProducts()
        {
            return GetAllProductsInternal().ToArrayAsync();
        }

        public Task<Product[]> GetProductsByPartialName(string partialName)
        {
            return GetProductsByFilter(prod => prod.Name.StartsWith(partialName));
        }

        public Task<Product[]> GetProductsByType(Guid productTypeId)
        {
            return GetProductsByFilter(prod => prod.ProductTypeId == productTypeId);
        }

        private Task<Product[]> GetProductsByFilter(Expression<Func<Product, bool>> filter)
        {
            var products = GetAllProductsInternal();
            return products.Where(filter).ToArrayAsync();
        }

        private IQueryable<Product> GetAllProductsInternal()
        {
            return _dbContext.Products
                .AsNoTracking()
                .Include(prod => prod.ProductPropertyValues)
                    .ThenInclude(val => val.Property)
                .Include(prod => prod.ProductPropertyValues)
                    .ThenInclude(val => val.EnumValue)
                .Include(val => val.ProductType)
                .Include(prod => prod.Prices);
        }
    }
}
