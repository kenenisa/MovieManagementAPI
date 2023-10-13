using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieManagementAPI.Infrastructure.Persistence;

using Microsoft.Extensions.DependencyInjection;

using MovieManagementAPI.Application.Features.Movie.MovieCreation;
using MovieManagementAPI.Application.Features.Movie.MovieRetrieval;

using Microsoft.OpenApi.Models;

using MovieManagementAPI.Application.Features.Cinema.CinemaCreation;

using MovieManagementAPI.Infrastructure.Persistence.Repositories;
using MovieManagementAPI.Domain.Interfaces;

using Microsoft.Extensions.Configuration;

namespace MovieManagementAPI.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Movie Management API v1"));
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICinemaRepository, CinemaRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Movie Management API", Version = "v1" });
            });
            services.AddScoped<MovieCreationUseCase>();
            services.AddScoped<MovieRetrievalUseCase>();
            // services.AddScoped<IDbContextSeed, DbContextSeed>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
