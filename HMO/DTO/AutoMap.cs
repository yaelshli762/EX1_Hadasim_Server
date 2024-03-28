using AutoMapper;
using DAL.Models;
using DTO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AutoMap : Profile
    {
        public AutoMap()
        {
            CreateMap<Patient, PatientsDTO>();
            CreateMap<PatientsDTO, Patient>();
            //CreateMap<Patient, PatientsDTO>().ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.Date));
            //CreateMap<PatientsDTO, Patient>().ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate));
            //CreateMap<PatientsDTO, Patient>().ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => src.BirthDate.ToDateTime(new TimeOnly(0, 0, 0))));

            CreateMap<PatientsCorona, PatientsCoronaDTO>();
            CreateMap<PatientsCoronaDTO, PatientsCorona>();
        }
    }
}
