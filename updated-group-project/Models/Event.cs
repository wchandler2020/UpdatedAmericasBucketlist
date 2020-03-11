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
        public string EventName { get; set; }
        public string EventType { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int EventPrice { get; set; }
        public string EventLocation { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool HaveBeen { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string UserName { get; set; }

    }
}
