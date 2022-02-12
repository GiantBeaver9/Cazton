using System.ComponentModel.DataAnnotations;

namespace WebAPIStore
{
    public class ShoppingCart
    {
        
        public int Id { get; set; }
        public StoreItems? StoreItem { get; set; }

        public int TotalPrice { get; set; }


    }
}
