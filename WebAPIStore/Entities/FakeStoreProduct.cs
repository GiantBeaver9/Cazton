using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebAPIStore.Entities
    
{
    public class FakeStoreProduct
    {
        private string defaultValue = "";
        [Key]
        public int Id  { get; set; }

        [NotNull]
        public string? itemName { get => defaultValue; set => defaultValue = value ?? throw new ArgumentNullException("Required"); }
        [NotNull]
        public string? Description   {get => defaultValue; set => defaultValue = value ?? throw new ArgumentNullException("Required");
    }
    [NotNull]
        public string? PictureSource  { get => defaultValue; set => defaultValue = value ?? throw new ArgumentNullException("Required");
    }
    public double Price { get; set; }
        public int Quantity { get; set; }
        [NotNull]
        public string? Category { get => defaultValue; set => defaultValue = value ?? throw new ArgumentNullException("Required");
    }

}
}
