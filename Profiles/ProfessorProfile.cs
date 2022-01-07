using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.Professor;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class ProfessorProfile : Profile
    {
        public ProfessorProfile()
        {          

            CreateMap<CreateProfessorDto, Professor>()
            
            .ForMember(
                dest => dest.nome,
                opt => opt.MapFrom(src => $"{src.nome}")
            )
            .ForMember(
                dest => dest.email,
                opt => opt.MapFrom(src => $"{src.email}")
            )
            .ForMember(
                dest => dest.disciplinaLecionada,
                opt => opt.MapFrom(src => $"{src.disciplinaLecionada}")
            )
            .ForMember(
                dest => dest.nascimento,
                opt => opt.MapFrom(src => $"{src.nascimento}")
            )
            .ForMember(
                dest => dest.endereco,
                opt => opt.MapFrom( src => src.endereco)
            );

            CreateMap<UpdateProfessorDto, Professor>()
            .ForMember(
                dest => dest.email,
                opt => opt.MapFrom(src => $"{src.email}")
            )
            .ForMember(
                dest => dest.endereco,
                opt => opt.MapFrom( src => src.endereco)
            );
        }
    }
}