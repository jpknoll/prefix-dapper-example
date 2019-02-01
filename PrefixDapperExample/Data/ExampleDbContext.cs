using System;
using Microsoft.EntityFrameworkCore;

namespace PrefixDapperExample.Data
{
    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext(DbContextOptions options)
            : base(options)
        { }

        public virtual DbSet<Order> Orders { get; set; }
    }
}
