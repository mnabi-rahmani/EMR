namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PartySkill
    {
        [Key]
        public int PartySkillIId { get; set; }

        public int? FKPSPartyId { get; set; }

        public int? FKPSSkillTypeId { get; set; }

        [StringLength(350)]
        public string Skill { get; set; }

        [StringLength(350)]
        public string SkillLocal { get; set; }

        public int? YearExprience { get; set; }

        public int? Rating { get; set; }

        public int? SkillLevel { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual Party Party { get; set; }

        public virtual SkillType SkillType { get; set; }
    }
}
