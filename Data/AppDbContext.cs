using System.Collections.Generic;
using JwtAuthExample.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthExample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
