using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace updated_group_project.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public Profile profile { get; set; }
    }

     public class Profile
     {
        [Key]
        public int ProfileId { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
     }

   
}
