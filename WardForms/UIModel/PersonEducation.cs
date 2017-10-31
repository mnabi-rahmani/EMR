namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonEducation")]
    public partial class PersonEducation
    {
        public int PersonEducationID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [StringLength(500)]
        public string EducationDetails { get; set; }

        public int? FKPEMRID { get; set; }

        public virtual Person Person { get; set; }
    }
}
