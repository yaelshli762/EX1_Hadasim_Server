using AutoMapper;
using DAL.Actions;
using DAL.Models;
using DTO.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Functions
{

    public class PatientCoronaFunctions
    {
        static IMapper _Mapper;
        static PatientCoronaFunctions()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.AutoMap>();
            });
            _Mapper = config.CreateMapper();
        }

        private PatientCoronaActions _actions;

        public PatientCoronaFunctions()
        {
            _actions = new PatientCoronaActions();
        }
        public List<PatientsCoronaDTO> GetAllPatientsCorona()
        {
            if (_actions == null)
                return null;
            List<PatientsCorona> patients = _actions.GetAllPatientCorona();
            List<PatientsCoronaDTO> patientsDTO = _Mapper.Map<List<PatientsCoronaDTO>>(patients);
            return patientsDTO;
        }

        public void AddPatientCorona(PatientsCoronaDTO pC)
        {
            if (_actions == null)
                return;
            PatientsCorona patientC = new PatientsCorona();
            patientC.PatientId = pC.PatientId;
            patientC.Vaccine1 = pC.Vaccine1;
            patientC.Vaccine2 = pC.Vaccine2;
            patientC.Vaccine3 = pC.Vaccine3;
            patientC.Vaccine4 = pC.Vaccine4;
            patientC.Manufacturer1 = pC.Manufacturer1;
            patientC.Manufacturer2 = pC.Manufacturer2;
            patientC.Manufacturer3 = pC.Manufacturer3;
            patientC.Manufacturer4 = pC.Manufacturer4;
            patientC.RecoveryDate = patientC.RecoveryDate;
            _actions.AddPatient(patientC);
        }

        public void DeletePatientCorona(int code)
        {
            if (_actions == null)
                return;
            _actions.DeletePatientCorona(code);
        }

        public List<PatientsCoronaDTO> UpdatePatientCorona(int code, PatientsCoronaDTO patient)
        {
            if (_actions == null)
                return null;
            PatientsCorona p = _Mapper.Map<PatientsCorona>(patient);
            List<PatientsCorona> list = _actions.UpdatePatientCorona(code, p);
            List<PatientsCoronaDTO> listDTO = _Mapper.Map<List<PatientsCoronaDTO>>(list);
            return listDTO;
        }

        public PatientsCoronaDTO getPatientCoronaById(string id)
        {
            List<PatientsCoronaDTO> patientsCorona = GetAllPatientsCorona();
            return patientsCorona.FirstOrDefault(pc => pc.PatientId == id);
        }
    }
}
