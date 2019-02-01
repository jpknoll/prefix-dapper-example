using System;

namespace PrefixDapperExample.Data
{
    public class DbInitializer
    {
        private readonly ExampleDbContext _dbContext;

        public DbInitializer(ExampleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Initialize()
        {
            _dbContext.Database.EnsureCreated();
        }
    }
}
