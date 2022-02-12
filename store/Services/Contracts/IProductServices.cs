using StoreModels.DTO;

namespace store.Services.Contracts
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductDTO>> GetItems()
        {

        }
    }
}
