using AutoMapper;
using Desafio.D1.Application.ViewModels;
using Desafio.D1.Domain.Entities;

namespace Desafio.D1.UI.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap()
                .ForMember(dest => dest.NumeroTel, opt => opt.MapFrom(src => src.NumeroTel))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<Cliente, ClienteUpdateViewModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

            CreateMap<Endereco, ClienteViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();

            CreateMap<Endereco, ClienteUpdateViewModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.EnderecoId));

            CreateMap<Telefone, ClienteViewModel>().ReverseMap()
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.NumeroTel));
            CreateMap<Telefone, ClienteUpdateViewModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TelefoneId));

            CreateMap<Telefone, TelefoneViewModel>().ReverseMap();

            CreateMap<ClientesEndereco, ClienteViewModel>().ReverseMap();
            CreateMap<ClientesTelefone, ClienteViewModel>().ReverseMap();
        }
    }
}
