namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyGroup")]
    public partial class PartyGroup
    {
        public int PartyGroupID { get; set; }

        [StringLength(150)]
        public string GroupName { get; set; }

        [StringLength(150)]
        public string GroupNameLocal { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? FKPGPartyID { get; set; }

        public virtual Party Party { get; set; }
    }
}
