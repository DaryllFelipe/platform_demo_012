using DataAccess.Private.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Private.Repository.Context
{
    internal class CustomerOrderContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "you connection here";
            optionsBuilder.UseSqlServer($"{connectionString}Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                 new Customer { CustomerId = 1, Name = "Carson Alexander", PhoneNumber = "09061111111" },
                new Customer { CustomerId = 2, Name = "Meredith Alonso", PhoneNumber = "09061111111" },
                new Customer { CustomerId = 3, Name = "Carson Anand", PhoneNumber = "09061111111" },
                new Customer { CustomerId = 4, Name = "Arturo Barzdukas", PhoneNumber = "09061111111" },
                new Customer { CustomerId = 5, Name = "Gytis Li", PhoneNumber = "09061111111" },
                new Customer { CustomerId = 6, Name = "Yan Justice", PhoneNumber = "09061111111" },
                new Customer { CustomerId = 7, Name = "Peggy Norman", PhoneNumber = "09061111111" },
                new Customer {CustomerId = 8, Name = "Laura Olivetto", PhoneNumber = "09061111111" },
                new Customer {CustomerId = 9, Name = "Nino Alexander", PhoneNumber = "09061111111" },
                new Customer {CustomerId = 10, Name = "Samson Alexander", PhoneNumber = "09061111111" }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, Amount = 10.10M, CustomerId = 1, OrderNumber = 1 },
                new Order { OrderId = 2, Amount = 10.10M, CustomerId = 1, OrderNumber = 2 },
                new Order { OrderId = 5, Amount = 10.10M, CustomerId = 1, OrderNumber = 5 },
                new Order { OrderId = 6, Amount = 10.10M, CustomerId = 2, OrderNumber = 6 },
                new Order { OrderId = 7, Amount = 10.10M, CustomerId = 2, OrderNumber = 7 },
                new Order { OrderId = 9, Amount = 10.10M, CustomerId = 2, OrderNumber = 9 },
                new Order { OrderId = 10, Amount = 10.10M, CustomerId = 2, OrderNumber = 10 },
                new Order { OrderId = 11, Amount = 10.10M, CustomerId = 3, OrderNumber = 11 },
                new Order {OrderId = 12, Amount = 10.10M, CustomerId = 3, OrderNumber = 12 },
                new Order {OrderId = 15, Amount = 10.10M, CustomerId = 3, OrderNumber = 15 },
                new Order { OrderId = 16, Amount = 10.10M, CustomerId = 4, OrderNumber = 16 },
                new Order {OrderId = 21, Amount = 10.10M, CustomerId = 5, OrderNumber = 21 },
                new Order {OrderId = 22, Amount = 10.10M, CustomerId = 5, OrderNumber = 22 },
                new Order { OrderId = 23, Amount = 10.10M, CustomerId = 5, OrderNumber = 23 },
                new Order { OrderId = 24, Amount = 10.10M, CustomerId = 5, OrderNumber = 24 },
                new Order { OrderId = 25, Amount = 10.10M, CustomerId = 5, OrderNumber = 25 },
                new Order { OrderId = 26, Amount = 10.10M, CustomerId = 6, OrderNumber = 26 },
                new Order { OrderId = 27, Amount = 10.10M, CustomerId = 6, OrderNumber = 27 },
                new Order { OrderId = 28, Amount = 10.10M, CustomerId = 6, OrderNumber = 28 },
                new Order { OrderId = 29, Amount = 10.10M, CustomerId = 6, OrderNumber = 29 },
                new Order { OrderId = 30, Amount = 10.10M, CustomerId = 6, OrderNumber = 30 },
                new Order { OrderId = 31, Amount = 10.10M, CustomerId = 7, OrderNumber = 31 },
                new Order { OrderId = 32, Amount = 10.10M, CustomerId = 7, OrderNumber = 32 },
                new Order { OrderId = 33, Amount = 10.10M, CustomerId = 7, OrderNumber = 33 },
                new Order { OrderId = 35, Amount = 10.10M, CustomerId = 7, OrderNumber = 35 },
                new Order { OrderId = 36, Amount = 10.10M, CustomerId = 8, OrderNumber = 36 },
                new Order { OrderId = 37, Amount = 10.10M, CustomerId = 8, OrderNumber = 37 },
                new Order { OrderId = 38, Amount = 10.10M, CustomerId = 8, OrderNumber = 38 },
                new Order { OrderId = 39, Amount = 10.10M, CustomerId = 8, OrderNumber = 39 },
                new Order { OrderId = 40, Amount = 10.10M, CustomerId = 8, OrderNumber = 40 },
                new Order { OrderId = 41, Amount = 10.10M, CustomerId = 9, OrderNumber = 41 },
                new Order { OrderId = 44, Amount = 10.10M, CustomerId = 9, OrderNumber = 44 },
                new Order { OrderId = 45, Amount = 10.10M, CustomerId = 9, OrderNumber = 45 },
                new Order { OrderId = 46, Amount = 10.10M, CustomerId = 10, OrderNumber = 46 },
                new Order { OrderId = 47, Amount = 10.10M, CustomerId = 10, OrderNumber = 47 },
                new Order { OrderId = 49, Amount = 10.10M, CustomerId = 10, OrderNumber = 49 },
                new Order { OrderId = 50, Amount = 10.10M, CustomerId = 10, OrderNumber = 50 }
            );
        }
    }
}
