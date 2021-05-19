using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiCovid.Models
{
    public class Region
    {
        public Region(string iso, string name, string province, string lat, string @long)
        {
            Iso = iso;
            Name = name;
            Province = province;
            Lat = lat;
            Long = @long;
        }

        public string Iso { get; set; }
        public string Name { get; set; }
        public string Province { get; set; }
        public string Lat { get; set; }
        public string Long { get; set; }
    }
}
