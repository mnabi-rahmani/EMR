namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            PartySkills = new HashSet<PartySkill>();
            PersonAddresses = new HashSet<PersonAddress>();
            PersonEducations = new HashSet<PersonEducation>();
            PersonOccupations = new HashSet<PersonOccupation>();
            PersonQualifications = new HashSet<PersonQualification>();
            PersonRoles = new HashSet<PersonRole>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartyID { get; set; }

        [StringLength(350)]
        public string Name { get; set; }

        [StringLength(350)]
        public string FatherName { get; set; }

        public int? Gender { get; set; }

        public int? MaritalStatus { get; set; }

        [StringLength(55)]
        public string PhoneNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int? BloodGroup { get; set; }

        [StringLength(60)]
        public string SocialSecurityNumber { get; set; }

        [StringLength(60)]
        public string PassportNumber { get; set; }

        public virtual Party Party { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartySkill> PartySkills { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonEducation> PersonEducations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonOccupation> PersonOccupations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonQualification> PersonQualifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonRole> PersonRoles { get; set; }
    }
}
