using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardForms.Models
{
    [Table("Person")]
    public class Person
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [StringLength(350)]
        public string FirstName { get; set; }

        [StringLength(350)]
        public string MiddleName { get; set; }

        [StringLength(350)]
        public string LastName { get; set; }

        [StringLength(350)]
        public string FatherName { get; set; }

        public int? Gender { get; set; }

        public int? MaritalStatus { get; set; }


        public DateTime? DateOfBirth { get; set; }

        public int? BloodGroup { get; set; }

        [StringLength(60)]
        public string TazkiraNumber { get; set; }

        [StringLength(60)]
        public string PassportNumber { get; set; }
        
    }
}