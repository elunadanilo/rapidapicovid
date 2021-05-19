using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiCovid.Models
{
    public class RegionCasesDeaths
    {
        public string Region { get; set; }
        public int Cases { get; set; }
        public int Deaths { get; set; }
    }
}
