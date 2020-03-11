using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace updated_group_project.Models
{
    public class Weather
    {
        [Key]
        public DateTime Date { get; set; }
        public string TodaysWeather { get; set; }
        public int Tempurature { get; set; }
    }
}
