namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataSetSectionElement")]
    public partial class DataSetSectionElement
    {
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

        public virtual ICollection<DataSetUIconfig> DataSetUIconfigs { get; set; }
    }
}
