﻿using Microsoft.EntityFrameworkCore;
using SEDC.PizzaApp.DataAccess.Relations;
using SEDC.PizzaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.DataAccess.Data
{
    public class PizzaAppDbContext : DbContext
    {
        public PizzaAppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            // Defining relationships
            //Check Fluent Api Entity Framework!!!

            RelationsResolver.AddOrderRelations(modelBuilder);

            modelBuilder.Entity<Pizza>()
                .HasMany(x => x.PizzaOrders)
                .WithOne(x => x.Pizza)
                .HasForeignKey(x => x.PizzaId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            //Data seed
            DataSeed.InsertDataInDb(modelBuilder);
        }
    }
}
