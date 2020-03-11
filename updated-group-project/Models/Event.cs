using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace updated_group_project.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public int last_item { get; set; }
        public string total_items { get; set; }
        public int first_item { get; set; }
        public string page_number { get; set; }
        public string page_size { get; set; }
        public int page_items { get; set; }
        public string search_time { get; set; }
        public string page_count { get; set; }
        public MainEvent events { get; set; }
    }

    public class Events
    {
        public Event[] _event { get; set; }
    }

    public class MainEvent
    {
        [Key]
        public int id { get; set; }
        public int watching_count { get; set; }
        public string olson_path { get; set; }
        public int calendar_count { get; set; }
        public int comment_count { get; set; }
        public string region_abbr { get; set; }
        public string postal_code { get; set; }
        public int going_count { get; set; }
        public int all_day { get; set; }
        public string latitude { get; set; }
        public string groups { get; set; }
        public string url { get; set; }
        public string privacy { get; set; }
        public string city_name { get; set; }
        public int link_count { get; set; }
        public string longitude { get; set; }
        public string country_name { get; set; }
        public string country_abbr { get; set; }
        public string region_name { get; set; }
        public string start_time { get; set; }
        public int tz_id { get; set; }
        public string description { get; set; }
        public string modified { get; set; }
        public string venue_display { get; set; }
        public string tz_country { get; set; }
        public string performers { get; set; }
        public string title { get; set; }
        public string venue_address { get; set; }
        public string geocode_type { get; set; }
        public string tz_olson_path { get; set; }
        public string recur_string { get; set; }
        public int calendars { get; set; }
        public string owner { get; set; }
        public bool going { get; set; }
        public string country_abbr2 { get; set; }
        public Image image { get; set; }
        public string created { get; set; }
        public string venue_id { get; set; }
        public string tz_city { get; set; }
        public string stop_time { get; set; }
        public string venue_name { get; set; }
        public string venue_url { get; set; }
    }

    public class Image
    {
        [Key]
        public int id { get; set; }
        public Small small { get; set; }
        public string width { get; set; }
        public string caption { get; set; }
        public Medium medium { get; set; }
        public string url { get; set; }
        public Thumb thumb { get; set; }
        public string height { get; set; }
    }

    public class Small
    {
        [Key]
        public int id { get; set; }
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Medium
    {
        [Key]
        public int id { get; set; }
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }

    public class Thumb
    {
        [Key]
        public int id { get; set; }
        public string width { get; set; }
        public string url { get; set; }
        public string height { get; set; }
    }



}

