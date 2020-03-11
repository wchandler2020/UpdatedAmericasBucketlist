using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using updated_group_project.Models;

namespace updated_group_project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<updated_group_project.Models.Weather> Weather { get; set; }
    }
}
