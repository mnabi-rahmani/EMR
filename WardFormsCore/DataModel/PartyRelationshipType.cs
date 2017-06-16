namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyRelationshipType")]
    public partial class PartyRelationshipType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartyRelationshipType()
        {
            PartyRelationships = new HashSet<PartyRelationship>();
        }

        public int PartyRelationshipTypeId { get; set; }

        [StringLength(500)]
        public string PartyRelationshipTypeDescription { get; set; }

        [StringLength(500)]
        public string PartyRelationshipTypeDescriptionLocal { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyRelationship> PartyRelationships { get; set; }
    }
}
