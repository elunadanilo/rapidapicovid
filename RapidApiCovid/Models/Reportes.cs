using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidApiCovid.Models
{
    public class Reportes
    {
        public Reportes(string date, string confirmed, string deaths, int recovered, int deaths_diff, string last_update, int active, int active_diff, float fatality_rate, Region region)
        {
            Date = date;
            Confirmed = confirmed;
            Deaths = deaths;
            Recovered = recovered;
            Deaths_diff = deaths_diff;
            Last_update = last_update;
            Active = active;
            Active_diff = active_diff;
            this.fatality_rate = fatality_rate;
            Region = region;
        }

        public string Date { get; set; }
        public string Confirmed { get; set; }
        public string Deaths { get; set; }
        public int Recovered { get; set; }
        public int Deaths_diff { get; set; }
        public string Last_update { get; set; }
        public int Active { get; set; }
        public int Active_diff { get; set; }
        public float fatality_rate { get; set; }
        public Region Region { get; set; }
    }
}
