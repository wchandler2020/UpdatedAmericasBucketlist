using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace updated_group_project.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Title { get; set; }
        public Catagory catagory { get; set; }
        public string description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool AllDay { get; set; }
        public int Price { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public bool Free { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool HaveBeen { get; set; }

        public class Catagory
        {
            [Key]
            public int Id { get;  set; }
            public string name { get; set; }

        }


        
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string UserName { get; set; }

    }
}
