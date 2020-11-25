using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace IndividualActivity_3.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Representative { get; set; }
        [DataType(DataType.MultilineText)]
        public string Code { get; set; }
        public string Address { get; set; }
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Date Modified")]
        public DateTime DateModified { get; set; }
        [Display(Name = "Supplier Type")]
        public SupplierType Type { get; set; }
    }
    public enum SupplierType
    {
        Local = 1,
        International = 2
    }
}
