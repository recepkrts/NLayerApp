﻿using Microsoft.EntityFrameworkCore;
using NLayer.Core.Entity;
using System.Reflection;

namespace Nlayer.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            {
                Id=1,
                Color="Kırmızı",
                Height=100,
                Width=100,
                ProductId=1,
            },new ProductFeature()
            {
                Id=2,
                Color="Sarı",
                Height=200,
                Width=100,
                ProductId=2,
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
