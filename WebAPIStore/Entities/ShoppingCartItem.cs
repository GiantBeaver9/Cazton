using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebAPIStore.Entities
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }


        public int ShopCartId { get; set; }
        [NotNull]
        public string? modelNumber { get; set; }
        [NotNull]
        public string? quantity     { get; set; }


    }
}
