using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreModels.DTO
{
    public class ProductDTO
    {
        public int Id   { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageLocation    { get; set; }
        public double Price { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }

    }
}
