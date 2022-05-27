using AutoMapper;
using IndustriaWebApi.Models.Dtos;
using IndustriaWebApi.Models.Entities;

namespace IndustriaWebApi.Services.Mappers
{
    public class MateriaPrimaProfile : Profile
    {
        public MateriaPrimaProfile()
        {
            CreateMap<MateriaPrima, MateriaPrimaDto>();
            CreateMap<MateriaPrimaDto, MateriaPrima>();
        }
    }
}
