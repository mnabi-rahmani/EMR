namespace WardFormsCore.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PartyRelationship")]
    public partial class PartyRelationship
    {
        public int PartyRelationshipID { get; set; }

        [StringLength(500)]
        public string PartyRelationshipDescription { get; set; }

        [StringLength(500)]
        public string PartyRelationshipDescriptionLocal { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? PartyIdTo { get; set; }

        public int? RoleTypeTo { get; set; }

        public int? PartyIdFrom { get; set; }

        public int? RoleTypeFrom { get; set; }

        [StringLength(255)]
        public string RelationshipName { get; set; }

        public int? PartyRelationshipTypeId { get; set; }

        public virtual Party Party { get; set; }

        public virtual Party Party1 { get; set; }

        public virtual PartyRelationshipType PartyRelationshipType { get; set; }

        public virtual PartyRole PartyRole { get; set; }

        public virtual PartyRole PartyRole1 { get; set; }
    }
}
