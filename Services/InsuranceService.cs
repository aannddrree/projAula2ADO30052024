using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class InsuranceService
    {

        private InsuranceRepository _repository;

        public InsuranceService()
        {
            _repository = new InsuranceRepository();
        }

        public int Insert(Insurance insurance)
        {
            return _repository.Insert(insurance);
        }
    }
}
