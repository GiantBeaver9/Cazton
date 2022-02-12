using StoreModels.DTO;
using WebAPIStore.Entities;

namespace WebAPIStore.Extensions
{
    public static class DTOConversions
    {
        public static IEnumerable<ProductDTO> ConvertToDTO(this IEnumerable<StoreItems> products)
        {
            return (from product in products
                    select new ProductDTO
                    {
                        Id = product.Id,
                        Name = product.ItemName,
                        Description = product.Description,
                        ImageLocation = product.PictureSource,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        Category = product.Category,
                    }).ToList();
        }

    }
}
