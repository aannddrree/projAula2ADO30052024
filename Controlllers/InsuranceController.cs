using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class InsuranceController
    {

        private InsuranceService _insuranceService;

        public InsuranceController()
        {
            _insuranceService = new InsuranceService();
        }

        public bool Insert(Insurance insurance)
        {
            return _insuranceService.Insert(insurance);
        }
    }
}
