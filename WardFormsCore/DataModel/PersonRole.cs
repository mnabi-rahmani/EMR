namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonRole")]
    public partial class PersonRole
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PersonRoleID { get; set; }

        public int? FKPRPersonRoleTypeID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FKPRMRID { get; set; }

        public virtual PersonInfo PersonInfo { get; set; }

        public virtual PersonRoleType PersonRoleType { get; set; }
    }
}
