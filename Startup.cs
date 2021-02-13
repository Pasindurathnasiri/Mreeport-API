using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MReportAPI.Data;
using MReportAPI.Data.EFCore;
using Microsoft.AspNetCore.Authentication;
using MReportAPI.Handler;

namespace MReportAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<MReportAPIContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MReportAPIContext")));

            services.AddScoped<EFCorePatientRepository>();
            services.AddScoped<EFCoreChannellingRepository>();
            services.AddScoped<AEFCoreDoctorRepository>();
            services.AddScoped<AEFCoreHospitalRepository>();
            services.AddScoped<EFCoreReportRepository>();
            services.AddScoped<EFCoreSuperAdminRepository>();
            
            services.AddScoped<EFCoreVaccineRepository>();

            services.AddSwaggerGen(gen =>
            {
                gen.SwaggerDoc("v1.0", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "MReport", Version = "v1.0" });
            });

            services.AddCors();

            //Doctor Autherization class add
            services.AddAuthentication("Doctor Authentication")
                .AddScheme<AuthenticationSchemeOptions, DoctorAuthhandle>("Doctor Authentication", null);

            //Hospital Autherization class add
            services.AddAuthentication("Hospital Authentication")
                .AddScheme<AuthenticationSchemeOptions, HospitalAuthHandle>("Hospital Authentication", null);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            

            app.UseRouting();
            

            app.UseCors(options =>
            options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseSwagger();

            app.UseSwaggerUI(ui =>
            {
                ui.SwaggerEndpoint("/swagger/v1.0/swagger.json", "MReport");
                //ui.RoutePrefix = string.Empty;
            });

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
