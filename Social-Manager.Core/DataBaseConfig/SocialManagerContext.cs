using Microsoft.EntityFrameworkCore;
using StreamG.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamG.Core.DataBaseConfig
{
    public class Stream_G_Context : DbContext
    {
        public Stream_G_Context(DbContextOptions options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

    }
}
