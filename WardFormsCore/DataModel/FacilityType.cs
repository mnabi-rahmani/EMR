namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityType")]
    public partial class FacilityType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityType()
        {
            Facilities = new HashSet<Facility>();
        }

        public int FacilityTypeID { get; set; }

        [Column("FacilityType")]
        [StringLength(350)]
        public string FacilityType1 { get; set; }

        [StringLength(350)]
        public string FacilityTypeLocal { get; set; }

        [StringLength(500)]
        public string FacilityTypeDescription { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}
