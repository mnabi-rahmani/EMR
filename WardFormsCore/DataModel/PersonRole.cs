namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonRole")]
    public partial class PersonRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonRole()
        {
            PartyRelationships = new HashSet<PartyRelationship>();
            PartyRelationships1 = new HashSet<PartyRelationship>();
        }

        public int PersonRoleID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? PartyID { get; set; }

        public int? RoleTypeId { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyRelationship> PartyRelationships { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyRelationship> PartyRelationships1 { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Person Person { get; set; }

        public virtual RoleType RoleType { get; set; }

        public virtual User User { get; set; }
    }
}
