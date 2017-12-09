namespace WardForms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityGroupRole")]
    public partial class FacilityGroupRole
    {
        [Key]
        public int FGRId { get; set; }

        public int? FKFGRFacilityGroupID { get; set; }

        public int? FKFGRFacilityPartyID { get; set; }

        public int? FKFGRRoleTypeID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public virtual FacilityGroup FacilityGroup { get; set; }
    }
}
