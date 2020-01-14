using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReal.Model.Entities
{
    public class Realtor : BaseEntity
    {
        public int RealtorId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(20, ErrorMessage = "First Name can only be 20 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(30, ErrorMessage = "Last Name can only be 30 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Company is required")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Commission Rate is required")]
        public double CommissionRate { get; set; }
    }
}
