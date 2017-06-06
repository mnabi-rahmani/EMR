namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Service")]
    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Refers = new HashSet<Refer>();
        }

        public int ServiceID { get; set; }

        public int? FKSFacillityID { get; set; }

        public int? FKSWardID { get; set; }

        public int? FKSPartyID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Purpose { get; set; }

        public virtual DataSetTbl DataSetTbl { get; set; }

        public virtual Facility Facility { get; set; }

        public virtual Party Party { get; set; }

        public virtual PurposeType PurposeType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Refer> Refers { get; set; }
    }
}
