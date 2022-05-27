using AutoMapper;
using IndustriaWebApi.Models.Dtos;
using IndustriaWebApi.Models.Entities;

namespace IndustriaWebApi.Services.Mappers
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<Produto, ProdutoDto>();
            CreateMap<ProdutoDto, Produto>();
        }
    }
}
