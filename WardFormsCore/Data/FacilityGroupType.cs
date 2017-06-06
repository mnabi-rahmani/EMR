namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityGroupType")]
    public partial class FacilityGroupType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityGroupType()
        {
            FacilityGroups = new HashSet<FacilityGroup>();
        }

        [Key]
        public int FGTID { get; set; }

        [Column("FacilityGroupType")]
        [Required]
        [StringLength(250)]
        public string FacilityGroupType1 { get; set; }

        [StringLength(350)]
        public string FacilityGroupTypeLocal { get; set; }

        [StringLength(500)]
        public string FacilityGroupTypeDescription { get; set; }

        public int? FKFGTFacilityID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityGroup> FacilityGroups { get; set; }
    }
}
