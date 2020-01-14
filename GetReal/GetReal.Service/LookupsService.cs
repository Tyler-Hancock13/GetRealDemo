using GetReal.Model;
using GetReal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetReal.Service
{
    public class LookupsService
    {
        private LookupsRepo repo = new LookUpsRepo();

        public List<CompanyLookup> GetAllCompanies()
        {
            return repo.GetAllCompanies();
        }
    }
}
