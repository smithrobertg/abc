using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airborne.Commander.AspNetCore.Models
{
    public class RosterEntry
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public Employee Employee { get; set; }
        public string Airbase { get; set; }
        public string Shift { get; set; }
        public string Status { get; set; }
        public string Assignment { get; set; }
        public float Hours { get; set; }
        public string Description { get; set; }
    }
}
