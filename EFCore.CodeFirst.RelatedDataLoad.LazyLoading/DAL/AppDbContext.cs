using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.RelatedDataLoad.LazyLoading.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextInitializer.Build();

            optionsBuilder
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseLazyLoadingProxies()
                .UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));
        }
    }
}