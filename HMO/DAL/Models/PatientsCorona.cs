using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class PatientsCorona
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

    public virtual Patient? Patient { get; set; }
}
