using AppVacunas.Server.DTOs;
using AppVacunas.Server.DTOs.Direccion;
using AppVacunas.Server.DTOs.Pais;
using AppVacunas.Server.DTOs.Persona;
using AppVacunas.Server.DTOs.Provincia;
using AppVacunas.Server.DTOs.Vacuna;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppVacunas.Server.Helpers {
    public class AutoMapperProfiles : Profile {
        public AutoMapperProfiles() {
            CreateMap<Persona, PersonaDTO>().ReverseMap();
            CreateMap<Persona, PersonaDireccionDTO>().ReverseMap();
            CreateMap<PersonaCreacionDTO, Persona>();

            CreateMap<Vacuna, VacunaDTO>().ReverseMap();
            CreateMap<VacunaCreacionDTO, Vacuna>();

            CreateMap<Pais, PaisDTO>().ReverseMap();
            CreateMap<Pais, PaisDireccionDTO>().ReverseMap();
            CreateMap<PaisCreacionDTO, Pais>();

            CreateMap<Provincia, ProvinciaDTO>().ReverseMap();
            CreateMap<Provincia, ProvinciaDireccionDTO>().ReverseMap();
            CreateMap<ProvinciaCreacionDTO, Provincia>();

            CreateMap<Direccion, DireccionDTO>().ReverseMap();
            CreateMap<DireccionCreacionDTO, Direccion>();
        }
    }
}
