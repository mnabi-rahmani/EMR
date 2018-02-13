using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WardForms.Models
{
    public class WardFormsContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WardFormsContext() : base("name=WardFormsContext")
        {
        }

        public System.Data.Entity.DbSet<WardForms.Models.FacilityContent> FacilityContents { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.FacilityGroup> FacilityGroups { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.FacilityGroupMember> FacilityGroupMembers { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.FacilityGroupRole> FacilityGroupRoles { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.FacilityGroupType> FacilityGroupTypes { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.FacilityParty> FacilityParties { get; set; }

        public System.Data.Entity.DbSet<WardForms.Models.FacilityRole> FacilityRoles { get; set; }
    }
}
