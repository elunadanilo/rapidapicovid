using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiCovid.Models
{
    public class ProvinciasCasesDeaths
    {
        public string Provincia { get; set; }
        public int Cases { get; set; }
        public int Deaths { get; set; }
    }
}
