using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

public class OrderContext : DbContext
{
    public OrderContext(DbContextOptions<OrderContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        //初始化数据
        Customer mike = new Customer {Id=100L,Name = "Mike", Phone = "13845691234", Address = "Wuhan" };
        Customer amy = new Customer {Id=101L,Name = "Amy", Phone = "13845123457", Address = "Beijing" };
        Customer john = new Customer {Id=102L, Name = "John", Phone = "13845123466", Address = "Shanghai" };
        Customer bob = new Customer { Id=103L,Name = "Bob", Phone = "13845123156", Address = "Guangzhou" };

        modelBuilder.Entity<Customer>().HasData(mike);
        modelBuilder.Entity<Customer>().HasData(amy);
        modelBuilder.Entity<Customer>().HasData(john);
        modelBuilder.Entity<Customer>().HasData(bob);

        Commodity phone = new Commodity() { Id=123456L,Name = "Phone", Price = 3999.9F };
        Commodity pen = new Commodity() {Id=123457L,Name = "Pen", Price = 9.5F };
        Commodity earphone = new Commodity() {Id=123458L,Name = "Earphone", Price = 399.9F };

        modelBuilder.Entity<Commodity>().HasData(phone);
        modelBuilder.Entity<Commodity>().HasData(pen);
        modelBuilder.Entity<Commodity>().HasData(earphone);
    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<Commodity> Commodities { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
}