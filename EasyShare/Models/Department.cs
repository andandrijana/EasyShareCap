using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class Department
    {
        public Department()
        {
            Projects = new HashSet<Projects>();
        }

        public int CompanyDepartmentId { get; set; }
        public int CompanyId { get; set; }
        public string Department1 { get; set; }

        public virtual Company Company { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
    }
}
