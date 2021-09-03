using Desafio.D1.Application.AppServices;
using Desafio.D1.Application.AppServices.Interfaces;
using Desafio.D1.Domain.Interfaces.Repository;
using Desafio.D1.Domain.Interfaces.Services;
using Desafio.D1.Domain.Services;
using Desafio.D1.Infra.Data;
using Desafio.D1.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.D1.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DesafioD1Context>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClientesEnderecoRepository, ClientesEnderecoRepository>();
            services.AddScoped<IClientesTelefoneRepository, ClientesTelefoneRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<ITelefoneService, TelefoneService>();
            services.AddScoped<IClientesEnderecoService, ClienteEnderecoService>();
            services.AddScoped<IClientesTelefoneService, ClientesTelefoneService>();

            services.AddScoped<IClienteAppService, ClienteAppService>();

            return services;
        }
    }
}
