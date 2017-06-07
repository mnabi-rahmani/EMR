namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityGroupMember")]
    public partial class FacilityGroupMember
    {
        [Key]
        public int FGMID { get; set; }

        public int? FKFGMFacilityGroupID { get; set; }

        [StringLength(500)]
        public string FacilityGroupMemberDescription { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? FKFGMFacilityID { get; set; }

        public virtual FacilityGroup FacilityGroup { get; set; }
    }
}
