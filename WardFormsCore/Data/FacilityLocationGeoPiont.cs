namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityLocationGeoPiont")]
    public partial class FacilityLocationGeoPiont
    {
        [Key]
        public int FLGeoPID { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        [StringLength(50)]
        public string Lan { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? Status { get; set; }

        public int? FKFLGPFacilityID { get; set; }

        [StringLength(500)]
        public string FacilityGeoPiontDescription { get; set; }

        public virtual Facility Facility { get; set; }
    }
}
