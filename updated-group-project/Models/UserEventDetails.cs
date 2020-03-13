using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace updated_group_project.Models
{
    public class UserEventDetails
    {
        [Key]
        public int IEventId { get; set; }
        public string title { get; set; }
        public string city_name { get; set; }
        public string description { get; set; }
        public string start_time { get; set; }
        public string stop_time { get; set; }
        public string venue_name { get; set; }
        public string venue_address { get; set; }
        public string review { get; set; }
        public int rating { get; set; }

        [ForeignKey("User")]

        public User ThisId { get; set; }

        public string ThisUsername { get; set; }
        
        



    }
}
