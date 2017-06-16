namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityParty")]
    public partial class FacilityParty
    {
        [Key]
        public int FPID { get; set; }

        public int? FKFPFacilityID { get; set; }

        public int? FKFPPartyID { get; set; }

        public int? FKFPRoleTypeID { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public virtual Facility Facility { get; set; }
    }
}
