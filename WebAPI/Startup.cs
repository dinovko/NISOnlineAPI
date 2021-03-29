using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ContextDB>(options => options.UseSqlServer(connectionString));

            services.AddCors();
            services.AddControllers();

            #region максимальный объем загружаемых данных
            services.Configure<IISServerOptions>(opt =>
            {
                opt.MaxRequestBodySize = int.MaxValue;
            });

            services.Configure<KestrelServerOptions>(opt =>
            {
                opt.Limits.MaxRequestBodySize = int.MaxValue;
            });

            services.Configure<FormOptions>(opt =>
            {
                opt.ValueLengthLimit = int.MaxValue;
                opt.MultipartBodyLengthLimit = int.MaxValue;
                opt.MultipartHeadersLengthLimit = int.MaxValue;
            });
            #endregion
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseDefaultFiles();
            app.UseStaticFiles();            

            app.UseRouting();
            
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
