using Microsoft.EntityFrameworkCore;
using Social_Manager.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Manager.Core.DataBaseConfig
{
    public class SocialManagerContext : DbContext
    {
        public SocialManagerContext(DbContextOptions options): base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ApplicationUser> Users { get; set; }

    }
}
