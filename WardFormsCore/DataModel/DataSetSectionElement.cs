namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataSetSectionElement")]
    public partial class DataSetSectionElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataSetSectionElement()
        {
            DataSetUIconfigs = new HashSet<DataSetUIconfig>();
        }

        [Key]
        public int DSSEId { get; set; }

        [Required]
        [StringLength(150)]
        public string DataSetSectionElementShortName { get; set; }

        [StringLength(250)]
        public string DataSetSectionElementName { get; set; }

        [StringLength(350)]
        public string DataSetNameSectionElementPersian { get; set; }

        [StringLength(350)]
        public string DataSetNameSectionElementPashto { get; set; }

        public int? FKDSSEDataSetSectionID { get; set; }

        public int? FKDSSEDataelementID { get; set; }

        public virtual DataElement DataElement { get; set; }

        public virtual DataSetSection DataSetSection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataSetUIconfig> DataSetUIconfigs { get; set; }
    }
}
