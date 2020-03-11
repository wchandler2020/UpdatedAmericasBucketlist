using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace updated_group_project.Models
{

    public class Rootobject
    {
        public Coord coord { get; set; }
        public MainWeather[] weather { get; set; }
        public string _base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
<<<<<<< HEAD
        public Rain rain { get; set; }
=======
>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Coord
    {
<<<<<<< HEAD
        public int lon { get; set; }
        public float lat { get; set; }
=======
        public float lon { get; set; }
        public int lat { get; set; }
>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4
    }

    public class Main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
<<<<<<< HEAD
        public float temp_min { get; set; }
        public float temp_max { get; set; }
=======
        public int temp_min { get; set; }
        public int temp_max { get; set; }
>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4
        public int pressure { get; set; }
        public int humidity { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; }
        public int deg { get; set; }
    }
<<<<<<< HEAD

    public class Rain
    {
        public float _1h { get; set; }
    }
=======
>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class MainWeather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

<<<<<<< HEAD
}

=======
}
>>>>>>> 6a405484ccd804595022bb4a73dfc52c686cd8a4
