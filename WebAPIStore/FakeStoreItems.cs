using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebAPIStore
{
    public class StoreItems
    {
        private string _itemName = "default";
        [NotNull]
        public String ItemName
        {
            get => _itemName;
            set => _itemName = value ?? throw new ArgumentNullException("Name is required.");
        }

        public int Price { get; set; }
        [Required]
        [NotNull]
        public string? Description { get; set; } 

        public int Id { get; set; }
        [NotNull]
        public string? PictureSource { get; set; }
        [NotNull]
        public string? Category { get; set; }
        public int Quantity { get; set; }

    }
}
