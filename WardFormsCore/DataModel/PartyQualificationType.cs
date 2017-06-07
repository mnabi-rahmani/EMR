namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyQualificationType")]
    public partial class PartyQualificationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartyQualificationType()
        {
            PartyQualifications = new HashSet<PartyQualification>();
        }

        public int PartyQualificationTypeID { get; set; }

        [StringLength(250)]
        public string QualificationType { get; set; }

        [StringLength(250)]
        public string QualificationTypeLocal { get; set; }

        [StringLength(500)]
        public string PartyQualificationTypeDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyQualification> PartyQualifications { get; set; }
    }
}
