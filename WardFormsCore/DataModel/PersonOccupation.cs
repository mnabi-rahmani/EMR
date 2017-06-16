namespace WardFormsCore.DataModel
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

        public int? FKPOMRID { get; set; }

        public virtual Person Person { get; set; }
    }
}
