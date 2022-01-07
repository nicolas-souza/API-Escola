using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Dtos.Aluno;
using API.Models;
using AutoMapper;

namespace API.Profiles
{
    public class AlunoProfile : Profile
    {
        public AlunoProfile()
        {
            CreateMap<CreateAlunoDto, Aluno>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => $"{src.Id}")
                )
                .ForMember(
                    dest => dest.nome,
                    opt => opt.MapFrom(src => $"{src.nome}")
                )
                .ForMember(
                    dest => dest.email,
                    opt => opt.MapFrom(src => $"{src.email}")
                )
                .ForMember(
                dest => dest.endereco,
                opt => opt.MapFrom( src => src)
            );;

            CreateMap<UpdateAlunoDto, Aluno>()
                .ForMember(
                    dest => dest.email,
                    opt => opt.MapFrom(src => $"{src.email}")
                )
                .ForMember(
                dest => dest.endereco,
                opt => opt.MapFrom( src => src.endereco)
            );;
        }
    }
}