namespace WardForms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacilityGroup")]
    public partial class FacilityGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacilityGroup()
        {
            FacilityGroupMembers = new HashSet<FacilityGroupMember>();
            FacilityGroupRoles = new HashSet<FacilityGroupRole>();
        }

        [Key]
        public int FGID { get; set; }

        public int? FKFGFacilityGroupTypeID { get; set; }

        [Column("FacilityGroup")]
        [StringLength(250)]
        public string FacilityGroup1 { get; set; }

        [StringLength(350)]
        public string FacilityGroupLocal { get; set; }

        public int? FKFGFacilityID { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual FacilityGroupType FacilityGroupType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityGroupMember> FacilityGroupMembers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityGroupRole> FacilityGroupRoles { get; set; }
    }
}
