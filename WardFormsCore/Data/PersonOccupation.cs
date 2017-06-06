namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonOccupation")]
    public partial class PersonOccupation
    {
        public int PersonOccupationID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [StringLength(500)]
        public string OccupationDetails { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FKPOMRID { get; set; }

        public virtual PersonInfo PersonInfo { get; set; }
    }
}
