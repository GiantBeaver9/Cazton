using Microsoft.EntityFrameworkCore;
using WebAPIStore.Data;
using WebAPIStore.Entities;
using WebAPIStore.Repos.Contracts;

namespace WebAPIStore.Repos
{
    public class ProductRepo : IProductRepo
    {
        private readonly FakeStoreDBContext _dbContext;
        public ProductRepo(FakeStoreDBContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        Task<FakeStoreProduct> IProductRepo.GetProduct(int ID)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<StoreItems>> IProductRepo.GetProducts()
        {

            var products = await _dbContext.Products!.ToListAsync();

            return (IEnumerable<StoreItems>)products;
        }
    }
}
