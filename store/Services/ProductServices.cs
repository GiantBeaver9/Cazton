using StoreModels.DTO;

namespace store.Services
{
    public class ProductServices

    {
        private readonly HttpClient httpClient;

        public ProductServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDTO>> GetItems()
        {
            try
            {
                var products = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDTO>>("api/products");  
            }
            catch (Exception ex)
            {
                throw new Exception()
            }
        }

    }
}
