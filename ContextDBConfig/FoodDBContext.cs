﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FoodApp.Models;

namespace FoodApp.ContextDBConfig
{
    public class FoodAppDBContext:IdentityDbContext<ApplicationUser>
    {
        public FoodAppDBContext() { 
        }
        public FoodAppDBContext(DbContextOptions<FoodAppDBContext> options):base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }
}
