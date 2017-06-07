namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyAddress")]
    public partial class PartyAddress
    {
        public int PartyAddressID { get; set; }

        public int? FKPAPartyId { get; set; }

        public int? PartyAddressProvince { get; set; }

        public int? PartyAddressDistrict { get; set; }

        [StringLength(500)]
        public string PartyAddressDescription { get; set; }

        public DateTime? PartyAddressStartDate { get; set; }

        public DateTime? PartyAddressThruDate { get; set; }

        public virtual District District { get; set; }

        public virtual Party Party { get; set; }

        public virtual Province Province { get; set; }
    }
}
