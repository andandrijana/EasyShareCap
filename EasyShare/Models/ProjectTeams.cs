using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class ProjectTeams
    {
        public int ProjectTeamId { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Projects ProjectTeam { get; set; }
    }
}
