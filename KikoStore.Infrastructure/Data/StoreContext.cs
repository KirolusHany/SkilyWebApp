using System;
using Company.ClassLibrary1;
using KikoStore.Core.Entities;
using KikoStore.Core.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KikoStore.Infrastructure.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<AppUser>(options)
{
    public DbSet<Product> Products { get;  set; }
    public DbSet<Address> Adresses { get;  set; }
    public DbSet<DeliveryMethod> DeliveryMethods { get;  set; }
    public DbSet<Order> Orders { get;  set; }
    public DbSet<OrderItem> OrderItems { get;  set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
