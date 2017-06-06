namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataSetSection")]
    public partial class DataSetSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataSetSection()
        {
            DataSetSectionElements = new HashSet<DataSetSectionElement>();
        }

        [Key]
        public int DSSID { get; set; }

        [Required]
        [StringLength(150)]
        public string DataSetSectionShortName { get; set; }

        [StringLength(250)]
        public string DataSetSectionName { get; set; }

        [StringLength(350)]
        public string DataSetNameSectionPersian { get; set; }

        [StringLength(350)]
        public string DataSetNameSectionPashto { get; set; }

        public int? FKDSSDataSetID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataSetSectionElement> DataSetSectionElements { get; set; }

        public virtual DataSetTbl DataSetTbl { get; set; }
    }
}
