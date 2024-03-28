using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Patient
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? CellPhone { get; set; }

    public string Adress { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public virtual ICollection<PatientsCorona> PatientsCoronas { get; } = new List<PatientsCorona>();
}
