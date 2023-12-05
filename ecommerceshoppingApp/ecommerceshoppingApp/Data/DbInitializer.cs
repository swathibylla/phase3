using ecommerceshoppingApp.Models;
using System;
using System.Linq;

namespace ecommerceshoppingApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product()
            {
                Id ="2",
                    Name="Hp",
                    Photo="Hp.jpg",
                    Price=3.80
            },
            new Product()
            {
                Id ="3",
                Name="Acer",
                Photo="Acer.jpg",
                Price=4.80
            },
            new Product()
            {
                Id ="4",
                Name="Microsoft",
                Photo="Microsoft.jpg",
                Price=5.80
            },
            new Product()
            {
                Id ="5",
                Name="Hp Pavilion",
                Photo="Hppavilion.jpg",
                Price=4.80
            },
            new Product()
            {
                Id ="6",
                Name="Dell insprion",
                Photo="Dellinsprion.jpg",
                Price=3.80
            },
            new Product()
            {
                Id ="7",
                Name="Acer Gaming",
                Photo="AcerGaming.jpg",
                Price=5.80
            },
            new Product()
            {
                Id ="8",
                Name="Dell Xp",
                Photo="DellXp.jpg",
                Price=5.80
            },
            new Product()
            {
                Id ="9",
                Name="Hp celeron",
                Photo="HpCeleron.jpg",
                Price=5.80
            },
            new Product()
            {
                Id ="10",
                Name="Acer Aspire",
                Photo="AcerAspire.jpg",
                Price=5.80
            }


            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();


        }
    }
}
       
        
   


