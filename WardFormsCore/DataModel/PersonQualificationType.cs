namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonQualificationType")]
    public partial class PersonQualificationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonQualificationType()
        {
            PersonQualifications = new HashSet<PersonQualification>();
        }

        public int PersonQualificationTypeID { get; set; }

        [StringLength(250)]
        public string QualificationType { get; set; }

        [StringLength(250)]
        public string QualificationTypeLocal { get; set; }

        [StringLength(500)]
        public string PartyQualificationTypeDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonQualification> PersonQualifications { get; set; }
    }
}
