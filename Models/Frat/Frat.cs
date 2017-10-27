using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class Frat : IFratForm
    {
        public int Id { get; set; }
        [DisplayName("FRAT Date")]
        [DisplayFormat(DataFormatString = "{0:d}")] // Short Date?
        public DateTimeOffset FratDate { get; set; }
        public string Shift { get; set; }
        public string AirBase { get; set; }
        public string Crew { get; set; }
        public WeatherBriefing WeatherBriefing { get; set; }
        public string AirbaseVmcOrImc { get; set; }
        public string StatewideVmcOrImc { get; set; }
        public string Tfr { get; set; }
        public Aircraft Aircraft { get; set; }
        public float Hobbs { get; set; }

        public List<StaticFrat> StaticFrat { get; set; }

        [NotMapped]
        public int Total { get => ((StaticFrat != null) ? StaticFrat.Sum(f => f.Total) : 0); }
    }

    public enum WeatherBriefing
    {
        Online,
        Phone
    }
}
