using System;
using System.Collections.Generic;
using System.Text;
using Cw916153.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cw916153.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<Cw916153.Models.ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Cw916153.Models.Post> Post { get; set; }
        public DbSet<Cw916153.Models.Comment> Comment { get; set; }
        public DbSet<Cw916153.Models.Module> Module { get; set; }

    }
}
