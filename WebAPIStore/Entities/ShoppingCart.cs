using System.ComponentModel.DataAnnotations;

namespace WebAPIStore.Entities
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }


        [Required]
        public int Item { get; set; }

    }
}
