using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Actions
{
    public class PatientCoronaActions
    {
        public HmoContext _db;
        public PatientCoronaActions()
        {
            _db = new HmoContext();
        }
        public List<PatientsCorona> GetAllPatientCorona()
        {
            return _db.PatientsCoronas.ToList();
        }

        public List<PatientsCorona> AddPatient(PatientsCorona patientC)
        {
            _db.PatientsCoronas.Add(patientC);
            _db.SaveChanges();
            return _db.PatientsCoronas.ToList();
        }

        public void DeletePatientCorona(int code)
        {
            var patientCoronaToDelete = _db.PatientsCoronas.FirstOrDefault(p => p.PatientCode == code);
            if (patientCoronaToDelete != null)
            {
                _db.PatientsCoronas.Remove(patientCoronaToDelete);
                _db.SaveChanges();
            }
        }

        public List<PatientsCorona> UpdatePatientCorona(int code, PatientsCorona patient)
        {
            PatientsCorona patientC = _db.PatientsCoronas.FirstOrDefault(p => p.PatientCode == code);
            if (patientC != null)
            {
                patientC.Vaccine1 = patient.Vaccine1;
                patientC.Vaccine2 = patient.Vaccine2;
                patientC.Vaccine3 = patient.Vaccine3;
                patientC.Vaccine4 = patient.Vaccine4;
                patientC.Manufacturer1 = patient.Manufacturer1;
                patientC.Manufacturer2 = patient.Manufacturer2;
                patientC.Manufacturer3 = patient.Manufacturer3;
                patientC.Manufacturer4 = patient.Manufacturer4;
                patientC.RecoveryDate = patient.RecoveryDate;
            }
            _db.SaveChanges();
            return _db.PatientsCoronas.ToList();
        }
    }
}

