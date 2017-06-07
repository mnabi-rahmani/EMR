namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityContent")]
    public partial class FacilityContent
    {
        [Key]
        public int FCID { get; set; }

        [Column("FacilityContent")]
        [StringLength(500)]
        public string FacilityContent1 { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? FKFCFacilityID { get; set; }

        public virtual Facility Facility { get; set; }
    }
}
