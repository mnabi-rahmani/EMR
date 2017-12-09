namespace WardForms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("District")]
    public partial class District
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public District()
        {
            Facilities = new HashSet<Facility>();
            //PartyAddresses = new HashSet<PartyAddress>();
            //PersonAddresses = new HashSet<PersonAddress>();
        }

        [Key]
        public int DistrictCode { get; set; }

        [Column("District")]
        [StringLength(250)]
        public string District1 { get; set; }

        [StringLength(350)]
        public string DistrictLocal { get; set; }

        public int? ProvinceCode { get; set; }

        public virtual Province Province { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facility> Facilities { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PartyAddress> PartyAddresses { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
