namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonQualification")]
    public partial class PersonQualification
    {
        [Key]
        public int PartyQualificationId { get; set; }

        public int? PartyID { get; set; }

        public int? PersonQualificationTypeId { get; set; }

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

        public virtual Person Person { get; set; }

        public virtual PersonQualificationType PersonQualificationType { get; set; }
    }
}
