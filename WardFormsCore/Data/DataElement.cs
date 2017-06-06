namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataElement")]
    public partial class DataElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataElement()
        {
            DataSetSectionElements = new HashSet<DataSetSectionElement>();
            ElementValues = new HashSet<ElementValue>();
        }

        [Key]
        public int DEID { get; set; }

        [Column("DataElement")]
        [StringLength(150)]
        public string DataElement1 { get; set; }

        [StringLength(350)]
        public string DataElementPersian { get; set; }

        [StringLength(350)]
        public string DataElementPashto { get; set; }

        public int? FKDEDataSetClassficationID { get; set; }

        public int? SortOrder { get; set; }

        public bool? DataElementStatus { get; set; }

        public virtual DataClassfication DataClassfication { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataSetSectionElement> DataSetSectionElements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ElementValue> ElementValues { get; set; }
    }
}
