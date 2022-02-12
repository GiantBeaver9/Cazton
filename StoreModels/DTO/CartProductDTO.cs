using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels.DTO
{
    public class CartProductDTO
    {
        public int Id   { get; set; }
        public int ProductId { get; set; }
        public int CartID { get; set; }
        public string? ItemName { get; set; }

        public string? Description   { get; set; }
        public string? ImageLocation     { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public int Quantity { get; set; }   

    }
}
