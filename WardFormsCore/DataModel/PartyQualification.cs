namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyQualification")]
    public partial class PartyQualification
    {
        public int PartyQualificationId { get; set; }

        public int? FKPQPartyID { get; set; }

        public int? FKPQPartyQualificationTypeId { get; set; }

        [StringLength(500)]
        public string PartyQualificationDescription { get; set; }

        [StringLength(500)]
        public string PartyQualificationDescriptionLocal { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [StringLength(250)]
        public string TitleLocal { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public virtual Party Party { get; set; }

        public virtual PartyQualificationType PartyQualificationType { get; set; }
    }
}
