namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyRole")]
    public partial class PartyRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PartyRole()
        {
            PartyRelationships = new HashSet<PartyRelationship>();
            PartyRelationships1 = new HashSet<PartyRelationship>();
        }

        public int PartyRoleID { get; set; }

        [StringLength(500)]
        public string PartyRoleDescription { get; set; }

        [StringLength(500)]
        public string PartyRoleDescriptionLocal { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? FKPRPartyID { get; set; }

        public int? FKPRRoleTypeId { get; set; }

        public virtual Party Party { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyRelationship> PartyRelationships { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyRelationship> PartyRelationships1 { get; set; }

        public virtual RoleType RoleType { get; set; }
    }
}
