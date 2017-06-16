namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataSetUIconfig")]
    public partial class DataSetUIconfig
    {
        [Key]
        public int DSUIID { get; set; }

        public int data_row { get; set; }

        public int data_col { get; set; }

        public int data_sizex { get; set; }

        public int data_sizey { get; set; }

        public bool? DataElementStatus { get; set; }

        public int DSSEId { get; set; }

        public virtual DataSetSectionElement DataSetSectionElement { get; set; }
    }
}
