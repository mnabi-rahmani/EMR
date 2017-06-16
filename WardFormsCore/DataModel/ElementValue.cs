namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ElementValue
    {
        [Key]
        public int DEVID { get; set; }

        public string DataElementValue { get; set; }

        public int? FKEVDataElementID { get; set; }

        public int? FKEVServiceID { get; set; }

        public virtual DataElement DataElement { get; set; }
    }
}
