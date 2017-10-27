using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Airborne.Commander.AspNetCore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [DisplayName("ID Number")]
        public string EmployeeId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Middle")]
        public string MiddleName { get; set; }
        public string Initials { get; set; }
        [DisplayName("AirBase")]
        public string Airbase { get; set; }
        public string Assignment { get; set; }
        public string Line { get; set; }

    }
}
