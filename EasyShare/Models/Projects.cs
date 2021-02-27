using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class Projects
    {
        public int ProjectId { get; set; }
        public int CompanyDepartmentId { get; set; }
        public int CompanyId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }

        public virtual Company Company { get; set; }
        public virtual Department CompanyDepartment { get; set; }
        public virtual ProjectTeams ProjectTeams { get; set; }
    }
}
