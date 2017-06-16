namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Refer")]
    public partial class Refer
    {
        public int ReferID { get; set; }

        public DateTime? ReferDate { get; set; }

        public int? ReferFrom { get; set; }

        public int? ReferTo { get; set; }

        public int? ReferWardTo { get; set; }

        [StringLength(500)]
        public string ReferDescription { get; set; }

        public virtual DataSetTbl DataSetTbl { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual Service Service { get; set; }
    }
}
