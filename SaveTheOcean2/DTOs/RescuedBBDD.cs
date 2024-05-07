using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean2.DTOs
{
    public class RescuedBBDD
    {
        public int Id { get; set; }
        public string IdRescured { get; set; }
        public DateTime Rescuedate { get; set; }
        public string Superfamily { get; set; }
        public int GradeAfectation { get; set; }
        public string Location { get; set; }
        public string NamePlayer { get; set; }
        public bool IsRescued { get; set; }

        public RescuedBBDD(string idRescured, DateTime rescuedate, string superfamily, int gradeAfectation, string location, string namePlayer, bool isRescued)
        {
            IdRescured = idRescured;
            Rescuedate = rescuedate;
            Superfamily = superfamily;
            GradeAfectation = gradeAfectation;
            Location = location;
            NamePlayer = namePlayer;
            IsRescued = isRescued;
        }

        public RescuedBBDD()
        {
        }
    }
}
