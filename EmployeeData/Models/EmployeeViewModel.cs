using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeData.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [DisplayName("LastName")]
        public string LastName { get; set; }
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public double Salary { get; set; }

        [DisplayName("Name")]
        public string FullName
        {
            get { return FirstName + "" + LastName; }
        }
    }
}
