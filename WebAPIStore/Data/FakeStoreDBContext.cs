using Microsoft.EntityFrameworkCore;
using WebAPIStore.Entities;

namespace WebAPIStore.Data
{
    public class FakeStoreDBContext : DbContext
    {
        public FakeStoreDBContext(DbContextOptions<FakeStoreDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FakeStoreProduct>().HasData(new FakeStoreProduct
            {
                Id = 5,
                itemName = "John Hardy Women's Legends Naga Gold & Silver Dragon Station Chain Bracelet",
                Description = "From our Legends Collection, the Naga was inspired by the mythical water dragon that protects the ocean's pearl. Wear facing inward to be bestowed with love and abundance, or outward for protection.",
                PictureSource = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                Price = 695.00,
                Quantity = 120,
                Category = "men's clothing"
            });

            modelBuilder.Entity<FakeStoreProduct>().HasData(new FakeStoreProduct
            {
                Id = 1,
                itemName = "Fjallraven - Foldsack No. 1 Backpack, Fits 15 Laptops",
                Description = "Your perfect pack for everyday use and walks in the forest. Stash your laptop (up to 15 inches) in the padded sleeve, your everyday",
                PictureSource = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                Price = 109.95,
                Quantity = 120,
                Category = "men's clothing"
            });

            modelBuilder.Entity<FakeStoreProduct>().HasData(new FakeStoreProduct
            {
                Id = 2,
                itemName = "Mens Casual Premium Slim Fit T-Shirts ",
                Description = "Slim - fitting style, contrast raglan long sleeve, three - button henley placket, light weight & soft fabric for breathable and comfortable wearing.And Solid stitched shirts with round neck made for durability and a great fit for casual fashion wear and diehard baseball fans.The Henley style round neckline includes a three - button placket.",
                PictureSource = "https://fakestoreapi.com/img/81fPKd-2AYL._AC_SL1500_.jpg",
                Price = 22.30,
                Quantity = 259,
                Category = "men's clothing"
            });

            modelBuilder.Entity<FakeStoreProduct>().HasData(new FakeStoreProduct
            {
                Id = 3,
                itemName = "Mens Cotton Jacket",
                Description = "great outerwear jackets for Spring / Autumn / Winter, suitable for many occasions, such as working, hiking, camping, mountain / rock climbing, cycling, traveling or other outdoors.Good gift choice for you or your family member.A warm hearted love to Father, husband or son in this thanksgiving or Christmas Day.",
                PictureSource = "https://fakestoreapi.com/img/71li-ujtlUL._AC_UX679_.jpg",
                Price = 55.99,
                Quantity = 500,
                Category = "men's clothing"
            });

            modelBuilder.Entity<FakeStoreProduct>().HasData(new FakeStoreProduct
            {
                Id = 4,
                itemName = "Mens Casual Slim Fit",
                Description = "The color could be slightly different between on the screen and in practice. / Please note that body builds vary by person, therefore, detailed size information should be reviewed below on the product description.",
                PictureSource = "https://fakestoreapi.com/img/71YXzeOuslL._AC_UY879_.jpg",
                Price = 15.99,
                Quantity = 430,
                Category = "men's clothing"
            });
        }

        public DbSet<FakeStoreProduct>? Products { get; set; }
        public DbSet<ShoppingCart>? ShoppingCarts { get; set;}
        public DbSet<User>? Users { get; set; }
        public DbSet<ShoppingCartItem>? Items { get; set; }
    }
}
