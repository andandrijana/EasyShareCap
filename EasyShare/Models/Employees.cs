using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class Employees
    {
        public Employees()
        {
            ProjectTeams = new HashSet<ProjectTeams>();
        }

        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyId { get; set; }
        public int SecurityId { get; set; }
        public DateTime LastLoggedIn { get; set; }

        public virtual UserSecurity Employee { get; set; }
        public virtual UserSecurity Security { get; set; }
        public virtual ICollection<ProjectTeams> ProjectTeams { get; set; }
    }
}
