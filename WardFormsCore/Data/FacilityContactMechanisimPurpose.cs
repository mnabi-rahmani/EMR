namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityContactMechanisimPurpose")]
    public partial class FacilityContactMechanisimPurpose
    {
        [Key]
        public int FCMPID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [StringLength(355)]
        public string ContactPurposeType { get; set; }

        public int? FKFCMPFCMID { get; set; }

        public virtual FacilityContactMechanisim FacilityContactMechanisim { get; set; }
    }
}
