using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardForms.Models
{
    public class FacilityViewModel
    {
        public int FacilityTypeID { get; set; }

        [Column("FacilityType")]
     
        public string FacilityType1 { get; set; }

       
        public string FacilityTypeLocal { get; set; }

      
        public string FacilityTypeDescription { get; set; }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FID { get; set; }

        public int FKFFacilityTypeID { get; set; }

        [StringLength(255)]
        public string FacilityName { get; set; }

        [StringLength(350)]
        public string FacilityNameLocal { get; set; }

        [StringLength(500)]
        public string FacilityDescription { get; set; }
        public int FLGeoPID { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        [StringLength(50)]
        public string Lan { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? ThruDate { get; set; }

        public int? Status { get; set; }

        public int? FKFLGPFacilityID { get; set; }

        [StringLength(500)]
        public string FacilityGeoPiontDescription { get; set; }


    }
}