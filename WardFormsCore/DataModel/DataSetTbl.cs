namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataSetTbl")]
    public partial class DataSetTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataSetTbl()
        {
            DataSetSections = new HashSet<DataSetSection>();
            Refers = new HashSet<Refer>();
            Services = new HashSet<Service>();
        }

        [Key]
        public int DSId { get; set; }

        [Required]
        [StringLength(150)]
        public string DataSetShortName { get; set; }

        [StringLength(250)]
        public string DataSetName { get; set; }

        [StringLength(350)]
        public string DataSetNamePersian { get; set; }

        [StringLength(350)]
        public string DataSetNamePashto { get; set; }

        [StringLength(100)]
        public string DataSetFor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataSetSection> DataSetSections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refer> Refers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service> Services { get; set; }
    }
}
