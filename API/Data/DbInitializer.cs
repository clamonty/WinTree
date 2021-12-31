using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{

    // Static class to seed database if empty on startup
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            // If Products DbSet has any entries, return without doing anything
            if (context.Products.Any()) return;

            // List of all the products in the store
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Burton Speedster Board 2000",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 20000,
                    PictureUrl = "/images/products/sb-burton1.png",
                    Brand = "Burton",
                    Type = "Boards",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Green Burton Board 3000",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 15000,
                    PictureUrl = "/images/products/sb-burton2.png",
                    Brand = "Burton",
                    Type = "Boards",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Bataleon Board Speed Rush 3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/sb-bataleon1.png",
                    Brand = "Bataleon",
                    Type = "Boards",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Bataleon Super Board",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et us et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 30000,
                    PictureUrl = "/images/products/sb-bataleon2.png",
                    Brand = "Bataleon",
                    Type = "Boards",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Arbor Super Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 25000,
                    PictureUrl = "/images/products/sb-arbor1.png",
                    Brand = "Arbor",
                    Type = "Boards",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Never Summer Industries Entry Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 12000,
                    PictureUrl = "/images/products/sb-nvsum1.png",
                    Brand = "Never Summer Industries",
                    Type = "Boards",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Bataleon Blue Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1000,
                    PictureUrl = "/images/products/hat-bataleon1.png",
                    Brand = "Bataleon",
                    Type = "Hats",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Green Arbor Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 8000,
                    PictureUrl = "/images/products/hat-arbor1.png",
                    Brand = "Arbor",
                    Type = "Hats",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Purple Arbor Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/hat-arbor2.png",
                    Brand = "Arbor",
                    Type = "Hats",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Blue Salomon Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1800,
                    PictureUrl = "/images/products/glove-salomon1.png",
                    Brand = "VS Salomon",
                    Type = "Gloves",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Green Salomon Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1500,
                    PictureUrl = "/images/products/glove-salomon2.png",
                    Brand = "VS Salomon",
                    Type = "Gloves",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Purple Arbor Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1600,
                    PictureUrl = "/images/products/glove-arbor1.png",
                    Brand = "Arbor",
                    Type = "Gloves",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Green Arbor Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 1400,
                    PictureUrl = "/images/products/glove-arbor2.png",
                    Brand = "Arbor",
                    Type = "Gloves",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "K2 Red Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 25000,
                    PictureUrl = "/images/products/boot-ktwo1.png",
                    Brand = "K2",
                    Type = "Boots",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Bataleon Red Boots",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18999,
                    PictureUrl = "/images/products/boot-bataleon2.png",
                    Brand = "Bataleon",
                    Type = "Boots",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Bataleon Purple Boots",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et us et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 19999,
                    PictureUrl = "/images/products/boot-bataleon1.png",
                    Brand = "Bataleon",
                    Type = "Boots",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Burton Purple Boots",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 15000,
                    PictureUrl = "/images/products/boot-burton2.png",
                    Brand = "Burton",
                    Type = "Boots",
                    QuantityAvailable = 100
                },
                new Product
                {
                    Name = "Burton Blue Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 18000,
                    PictureUrl = "/images/products/boot-burton1.png",
                    Brand = "Burton",
                    Type = "Boots",
                    QuantityAvailable = 100
                },
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}