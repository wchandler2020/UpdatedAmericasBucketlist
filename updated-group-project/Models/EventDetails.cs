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
        public string cityName { get; set; }
        public string desciption { get; set; }
        public string startTime { get; set; }
        public string stopTime { get; set; }
        public string venueDisplay { get; set; }
        public string title { get; set; }
        public string venueAddress { get; set; }
        public string image { get; set; }
        public string venue_name { get; set; }
        public string url { get; set; }
    }
}
