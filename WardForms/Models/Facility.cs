namespace WardForms.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Facility")]
    public partial class Facility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facility()
        {
            FacilityContactMechanisims = new HashSet<FacilityContactMechanisim>();
            FacilityContents = new HashSet<FacilityContent>();
            FacilityGroups = new HashSet<FacilityGroup>();
            FacilityLocationGeoPionts = new HashSet<FacilityLocationGeoPiont>();
            FacilityParties = new HashSet<FacilityParty>();
            FacilityRoles = new HashSet<FacilityRole>();
            //Refers = new HashSet<Refer>();
            //Services = new HashSet<Service>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FID { get; set; }

        public int FKFFacilityTypeID { get; set; }

        [StringLength(255)]
        public string FacilityName { get; set; }

        [StringLength(350)]
        public string FacilityNameLocal { get; set; }

        [StringLength(500)]
        public string FacilityDescription { get; set; }

        public DateTime? EstablishmentDate { get; set; }

        public int? FKFDisctictCode { get; set; }

        public int? FKFProvinceCode { get; set; }

        public virtual District District { get; set; }

        public virtual FacilityType FacilityType { get; set; }

        public virtual Province Province { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityContactMechanisim> FacilityContactMechanisims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityContent> FacilityContents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityGroup> FacilityGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityLocationGeoPiont> FacilityLocationGeoPionts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityParty> FacilityParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacilityRole> FacilityRoles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Refer> Refers { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Service> Services { get; set; }
    }
}
