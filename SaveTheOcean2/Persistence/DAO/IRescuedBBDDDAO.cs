using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveTheOcean2.DTOs;

namespace SaveTheOcean2.Persistence.DAO
{
    public interface IRescuedBBDDDAO
    {
        RescuedBBDD GetRescuedBBDDById(int id);
        public IEnumerable<RescuedBBDD> GetAllRescuedsBBDD();
        void AddRescuedBBDD(RescuedBBDD animal);
        void UpdateRescuedBBDD(RescuedBBDD animal);
        void DeleteRescuedBBDD(int id);
    }
}
