namespace WardForms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityRole")]
    public partial class FacilityRole
    {
        public int FacilityRoleID { get; set; }

        public int? FKFRFacilityID { get; set; }

        public int? FKFRPartyID { get; set; }

        public int? FKFRRoleTypeID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public virtual Facility Facility { get; set; }
    }
}
