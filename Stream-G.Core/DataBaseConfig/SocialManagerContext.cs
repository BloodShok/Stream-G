using Microsoft.EntityFrameworkCore;
using StreamG.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamG.Core.DataBaseConfig
{
    public class StreamGContext : DbContext
    {
        public StreamGContext(DbContextOptions options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

    }
}
