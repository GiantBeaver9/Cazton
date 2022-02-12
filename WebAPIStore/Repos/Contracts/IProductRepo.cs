using WebAPIStore.Entities;

namespace WebAPIStore.Repos.Contracts
{
    public interface IProductRepo
    {
        Task<IEnumerable<StoreItems>> GetProducts();
        Task<FakeStoreProduct> GetProduct(int ID);

    }
}
