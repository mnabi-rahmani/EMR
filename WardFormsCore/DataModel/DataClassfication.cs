namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataClassfication")]
    public partial class DataClassfication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataClassfication()
        {
            DataElements = new HashSet<DataElement>();
        }

        [Key]
        public int DataClsID { get; set; }

        [Column("DataClassfication")]
        [Required]
        [StringLength(250)]
        public string DataClassfication1 { get; set; }

        [StringLength(350)]
        public string DataClassficationPersian { get; set; }

        [StringLength(350)]
        public string DataClassficationPashto { get; set; }

        [StringLength(500)]
        public string DataClassficationDescription { get; set; }

        public bool? DataClassficationStatus { get; set; }

        [StringLength(250)]
        public string DataClassficationFor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataElement> DataElements { get; set; }
    }
}
