namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonRoleType")]
    public partial class PersonRoleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonRoleType()
        {
            PersonRoles = new HashSet<PersonRole>();
        }

        public int PersonRoleTypeID { get; set; }

        [Column("PersonRoleType")]
        [StringLength(350)]
        public string PersonRoleType1 { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonRole> PersonRoles { get; set; }
    }
}
