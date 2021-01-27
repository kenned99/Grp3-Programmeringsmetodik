using Microsoft.EntityFrameworkCore;
using ServerSide.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide
{
    public class CockTailsDBContext : DbContext
    {
        public CockTailsDBContext(DbContextOptions<CockTailsDBContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}