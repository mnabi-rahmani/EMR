namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Party")]
    public partial class Party
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Party()
        {
            PartyGroups = new HashSet<PartyGroup>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PartyID { get; set; }

        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThruDate { get; set; }

        public int? PartyTypeID { get; set; }

        public virtual Organization Organization { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartyGroup> PartyGroups { get; set; }

        public virtual Person Person { get; set; }

        public virtual PartyType PartyType { get; set; }
    }
}
