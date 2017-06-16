namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityContactMechanisim")]
    public partial class FacilityContactMechanisim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityContactMechanisim()
        {
            FacilityContactMechanisimPurposes = new HashSet<FacilityContactMechanisimPurpose>();
        }

        [Key]
        public int FMID { get; set; }

        public int? FKFCMFacilityID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public virtual Facility Facility { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityContactMechanisimPurpose> FacilityContactMechanisimPurposes { get; set; }
    }
}
