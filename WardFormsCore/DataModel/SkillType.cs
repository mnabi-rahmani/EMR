namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SkillType")]
    public partial class SkillType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SkillType()
        {
            PartySkills = new HashSet<PartySkill>();
        }

        public int SkillTypeID { get; set; }

        [StringLength(350)]
        public string SkillDescription { get; set; }

        [StringLength(350)]
        public string SkillDescriptionLocal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartySkill> PartySkills { get; set; }
    }
}
