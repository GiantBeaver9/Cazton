using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels.DTO
{
    internal class CartItemToAddDTO
    {
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

    }
}
