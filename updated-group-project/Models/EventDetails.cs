using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace updated_group_project.Models
{
    public class EventDetails
    {
        [Key]
        public int Id { get; set; }
        public string city_name { get; set; }
        public string description { get; set; }
        public string start_time { get; set; }
        public string stop_time { get; set; }
        public string title { get; set; }
        public string venue_name { get; set; }
      

    }
}
