using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Entity;

namespace Nlayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                Name = "Kalem1",
                CategoryId = 1,
                Price = 100,
                Stock = 20,
                InsertDate = DateTime.Now
            }, new Product
            {
                Id = 2,
                Name = "Kalem2",
                CategoryId = 1,
                Price = 200,
                Stock = 20,
                InsertDate = DateTime.Now
            }, new Product
            {
                Id = 3,
                Name = "Kalem3",
                CategoryId = 1,
                Price = 300,
                Stock = 20,
                InsertDate = DateTime.Now
            }, new Product
            {
                Id = 4,
                Name = "Kitap1",
                CategoryId = 2,
                Price = 600,
                Stock = 50,
                InsertDate = DateTime.Now
            }, new Product
            {
                Id = 5,
                Name = "Kitap2",
                CategoryId = 2,
                Price = 700,
                Stock = 30,
                InsertDate = DateTime.Now
            });
        }
    }
}
