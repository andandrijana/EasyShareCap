using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyTags = new HashSet<CompanyTags>();
            Department = new HashSet<Department>();
            ProjectTags = new HashSet<ProjectTags>();
            ProjectTeams = new HashSet<ProjectTeams>();
            Projects = new HashSet<Projects>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<CompanyTags> CompanyTags { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<ProjectTags> ProjectTags { get; set; }
        public virtual ICollection<ProjectTeams> ProjectTeams { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
