using AutoMapper;
using Desafio.D1.Application.ViewModels;
using Desafio.D1.Domain.Entities;

namespace Desafio.D1.API.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap()
                .ForMember(dest => dest.NumeroTel, opt => opt.MapFrom(src => src.NumeroTel));
            CreateMap<Cliente, ClienteUpdateViewModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdCliente));

            CreateMap<Endereco, ClienteViewModel>().ReverseMap();
            CreateMap<Endereco, ClienteUpdateViewModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdEndereco));

            CreateMap<Telefone, ClienteViewModel>().ReverseMap();
            CreateMap<Telefone, ClienteUpdateViewModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.IdTelefone));

            CreateMap<ClientesEndereco, ClienteViewModel>().ReverseMap();
            CreateMap<ClientesTelefone, ClienteViewModel>().ReverseMap();
        }
    }
}
