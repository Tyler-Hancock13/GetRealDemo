using GetReal.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetReal.Models
{
    public class RealtorAddEditVM
    {
        public Realtor Realtor { get; set; }
        public List<SelectListItem> Companies { get; set; }
    }
}