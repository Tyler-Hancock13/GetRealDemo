using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReal.Model.DTO
{
    class RealtorList
    {
        [Display(Name = "Id")]
        public int RealtorId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Company")]
        public int CompanyId { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Commission Rate")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        public double CommissionRate { get; set; }
    }
}
