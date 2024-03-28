using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Actions;
using DAL.Models;
using DTO.Repository;
using Microsoft.Extensions.Configuration;


namespace BLL.Functions
{
    public class PatientFunctions
    {
        static IMapper _Mapper;
        static PatientFunctions()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.AutoMap>();
            });
            _Mapper = config.CreateMapper();
        }

        private readonly PatientsActions _actions;
        public PatientFunctions()
        {
            _actions = new PatientsActions();
        }
        public List<PatientsDTO> GetAllPatients()
        {
            if (_actions == null)
                return null;
            List<Patient> patients = _actions.GetAllPatients();
            //Error
            List<PatientsDTO> patientsDTO = _Mapper.Map<List<PatientsDTO>>(patients);
            return patientsDTO;
        }

        public void AddPatient(PatientsDTO p)
        {
            if (_actions == null)
                return;
            //PatientsDTO patient = new PatientsDTO();
            Patient patient = new Patient();
            patient.Id = p.Id;
            patient.FirstName = p.FirstName;
            patient.LastName = p.LastName;
            patient.Phone = p.Phone;
            patient.Adress = p.Adress;
            patient.BirthDate = p.BirthDate;//new DateOnly(birthDate.Year, birthDate.Month, birthDate.Day);
            patient.CellPhone = p.CellPhone;
            //Patient p = _Mapper.Map<Patient>(patient);
            PatientCoronaActions action = new PatientCoronaActions();
            PatientsCorona patientCorona = new PatientsCorona();
            patientCorona.PatientId = p.Id;   
            _actions.AddPatient(patient);
            action.AddPatient(patientCorona);
        }

        public void DeletePatient(string id)
        {
            if (_actions == null)
                return;
            _actions.DeletePatient(id);
        }

        public List<PatientsDTO> UpdatePatient(string id, PatientsDTO p)
        {
            if (_actions == null)
                return null;
            Patient patient = _Mapper.Map<Patient>(p);
            List<Patient> list = _actions.UpdatePatient(id, patient);
            List<PatientsDTO> listDTO = _Mapper.Map<List<PatientsDTO>>(list);
            return listDTO;
        }

    }
}
