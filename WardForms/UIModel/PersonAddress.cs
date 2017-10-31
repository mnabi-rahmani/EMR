namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonAddress")]
    public partial class PersonAddress
    {
        [Key]
        public int AddressID { get; set; }

        [StringLength(250)]
        public string AddressType { get; set; }

        public int? Province { get; set; }

        public int? District { get; set; }

        [StringLength(700)]
        public string ExactLocation { get; set; }

        public int? StayLength { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? FKPAMRID { get; set; }

        public virtual District District1 { get; set; }

        public virtual Person Person { get; set; }

        public virtual Province Province1 { get; set; }
    }
}
