namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AllElement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DSId { get; set; }

        [Key]
        [Column(Order = 1)]
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

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DSSID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(150)]
        public string DataSetSectionShortName { get; set; }

        [StringLength(250)]
        public string DataSetSectionName { get; set; }

        [StringLength(350)]
        public string DataSetNameSectionPersian { get; set; }

        [StringLength(350)]
        public string DataSetNameSectionPashto { get; set; }

        public int? FKDSSDataSetID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DSSEId { get; set; }

        [Key]
        [Column(Order = 5)]
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

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DEID { get; set; }

        [StringLength(150)]
        public string DataElement { get; set; }

        [StringLength(350)]
        public string DataElementPersian { get; set; }

        [StringLength(350)]
        public string DataElementPashto { get; set; }

        public int? FKDEDataSetClassficationID { get; set; }

        public int? SortOrder { get; set; }

        public bool? DataElementStatus { get; set; }
    }
}
