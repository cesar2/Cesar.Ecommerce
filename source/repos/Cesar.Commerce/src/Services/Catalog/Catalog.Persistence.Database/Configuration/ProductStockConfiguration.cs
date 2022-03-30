using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    class ProductStockConfiguration
    {
        public ProductStockConfiguration(EntityTypeBuilder<ProductStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductStockId);
            var random = new Random();
            var productStocks = new List<ProductStock>();

            for (int i = 1; i < 100; i++)
            {
                productStocks.Add(new ProductStock
                {
                    ProductStockId = i,
                    ProductId = i,
                    Stock = random.Next(0, 20)

                });
            }

            entityBuilder.HasData(productStocks);
           
        }
    }
}
