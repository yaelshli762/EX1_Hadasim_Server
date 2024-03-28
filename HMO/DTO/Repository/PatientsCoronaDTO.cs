using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Repository
{
    public class PatientsCoronaDTO
    {
        public int PatientCode { get; set; }

        public string? PatientId { get; set; }

        public DateTime? Vaccine1 { get; set; }

        public DateTime? Vaccine2 { get; set; }

        public DateTime? Vaccine3 { get; set; }

        public DateTime? Vaccine4 { get; set; }

        public string? Manufacturer1 { get; set; }

        public string? Manufacturer2 { get; set; }

        public string? Manufacturer3 { get; set; }

        public string? Manufacturer4 { get; set; }

        public DateTime? RecoveryDate { get; set; }

    }
}
