using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Actions
{
    public class PatientsActions
    {
        public HmoContext _db;
        public PatientsActions()
        {
            _db = new HmoContext();
        }
        public List<Patient> GetAllPatients()
        {
            return _db.Patients.ToList();
        }

        public void AddPatient(Patient patient)
        {
            _db.Patients.Add(patient);
            _db.SaveChanges();
        }

        public void DeletePatient(string id)
        {
            var patientToDelete = _db.Patients.FirstOrDefault(x => x.Id == id);
            if (patientToDelete != null)
            {
                _db.Patients.Remove(patientToDelete);
                _db.SaveChanges();
            }
        }

        public List<Patient> UpdatePatient(string id, Patient p)
        {
            Patient patient = _db.Patients.FirstOrDefault(p => p.Id == id);
            if(patient != null)
            {
                patient.FirstName = p.FirstName;
                patient.LastName = p.LastName;
                patient.Phone = p.Phone;
                patient.Adress = p.Adress;
                patient.BirthDate = p.BirthDate;
                patient.CellPhone = p.CellPhone != null ? p.CellPhone : patient.CellPhone;
            }
            _db.SaveChanges();
            return _db.Patients.ToList();
        }
    }
}
