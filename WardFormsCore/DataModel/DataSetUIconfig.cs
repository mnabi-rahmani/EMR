using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WardFormsCore.Data
{


    [Table("DataSetUIconfig")]
    public partial class DataSetUIconfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
            "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataSetUIconfig()
        {
            //   DataSetSectionElements = new HashSet<DataSetSectionElement>();
            //     DataElements = new HashSet<DataElement>();
        }

        [Key]
        public int DSUIID { get; set; }




        public int data_row { get; set; }

        public int data_col { get; set; }

        public int data_sizex { get; set; }

        public int data_sizey { get; set; }


        public bool? DataElementStatus { get; set; }

        public int DSSEId { get; set; }

        public virtual DataSetSectionElement DataSetSectionElement { get; set; }

   //     [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
       //     "CA2227:CollectionPropertiesShouldBeReadOnly")]
        


        //  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //   public virtual ICollection<DataElement> DataElements { get; set; }
    }


}