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
        public DbSet<EventDetails> EventDetails { get; set; }
        public DbSet<User> User { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
        
=======
<<<<<<< HEAD
        
=======
>>>>>>> bf290455bf741048d9a861ea43534464592ac516
>>>>>>> 6bbd1a172bb2611a753be1824ee1a355f87c9657
=======

>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4
    }
}
