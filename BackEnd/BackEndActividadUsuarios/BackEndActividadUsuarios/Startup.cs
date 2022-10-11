using BackEndActividadUsuarios.Servicios.ActividadesUsuario;
using BackEndActividadUsuarios.Servicios.CredencialesUsuario;
using Microsoft.EntityFrameworkCore;

namespace BackEndActividadUsuarios
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        //servicios
        public void ConfigureServices(IServiceCollection services)
        {
            // Add services to the container.

            services.AddControllers();
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            services.AddAutoMapper(typeof(Startup));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddScoped<IActividadesUsuarioServices, ActividadesUsuarioServices>();
            services.AddScoped<ICredencialesUsuarioServices, CredencialesUsuarioServices>();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddCors(opciones =>
            {
                opciones.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            // Configure the HTTP request pipeline.
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
