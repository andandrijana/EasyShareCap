using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class UserSecurity
    {
        public UserSecurity()
        {
            EmployeesSecurity = new HashSet<Employees>();
        }

        public int SecurityId { get; set; }
        public string SecurityLevel { get; set; }

        public virtual Employees EmployeesEmployee { get; set; }
        public virtual ICollection<Employees> EmployeesSecurity { get; set; }
    }
}
