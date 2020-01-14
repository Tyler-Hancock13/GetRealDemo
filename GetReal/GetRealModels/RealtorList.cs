using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetRealModels
{
    public class RealtorList
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CompanyId { get; set; }

        public DateTime StartDate { get; set; }

        public decimal CommissionRate { get; set; }
    }
}