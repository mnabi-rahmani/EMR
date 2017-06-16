namespace WardFormsCore.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PersonRoleID { get; set; }

        public int EmployeeID { get; set; }

        public virtual PersonRole PersonRole { get; set; }
    }
}
