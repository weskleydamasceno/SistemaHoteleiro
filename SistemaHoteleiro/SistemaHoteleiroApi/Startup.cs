using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.IO;
using SistemaHoteleiro.Models;
using Microsoft.EntityFrameworkCore;
using SistemaHoteleiro.Repositories;
using SistemaHoteleiro.Services;

namespace SistemaHoteleiroApi
{
    public class Startup
    {
        private static IConfigurationRoot Configuration;

        public Startup()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = configurationBuilder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            //especifica o banco de dados que é injetado no contêiner de serviço.
            services.AddDbContext<SistemaHoteleiroContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("StoreDB")));
            services.AddMvc();

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ICheckinCheckoutRepository, CheckinCheckoutRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteTelefoneRepository, ClienteTelefoneRepository>();
            services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IQuartoRepository, QuartoRepository>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
            services.AddScoped<IReservaServicoRepository, ReservaServicoRepository>();
            services.AddScoped<IServicoRepository, ServicoRepository>();
            services.AddScoped<ITipoReservaRepository, TipoReservaRepository>();

            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<ICheckinCheckoutService, CheckinCheckoutService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteTelefoneService, ClienteTelefoneService>();
            services.AddScoped<IFuncionarioService, FuncionarioService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IQuartoService, QuartoService>();
            services.AddScoped<IReservaService, ReservaService>();
            services.AddScoped<IReservaServicoService, ReservaServicoService>();
            services.AddScoped<IServicoService, ServicoService>();
            services.AddScoped<ITipoReservaService, TipoReservaService>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}
