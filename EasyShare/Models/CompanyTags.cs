using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class CompanyTags
    {
        public int CompanyTagId { get; set; }
        public int CompanyId { get; set; }
        public string Tag { get; set; }

        public virtual Company Company { get; set; }
    }
}
