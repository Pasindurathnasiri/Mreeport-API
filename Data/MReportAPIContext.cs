using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MReportAPI.Models;

namespace MReportAPI.Data
{
    public class MReportAPIContext : DbContext
    {
        public MReportAPIContext (DbContextOptions<MReportAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MReportAPI.Models.Channelling> Channelling { get; set; }

        public DbSet<MReportAPI.Models.Doctor> Doctor { get; set; }

        public DbSet<MReportAPI.Models.Hospital> Hospital { get; set; }

        public DbSet<MReportAPI.Models.Patient> Patient { get; set; }

        public DbSet<MReportAPI.Models.Report> Report { get; set; }

        public DbSet<MReportAPI.Models.SuperAdmin> SuperAdmin { get; set; }

        public DbSet<MReportAPI.Models.Vaccine> Vaccine { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=tcp:mreportserver.database.windows.net,1433;Initial Catalog=MReport;Persist Security Info=False;User ID=mreportadmin;Password=Pasindu@kln6644;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress01;Initial Catalog=MReport;Integrated Security=True");
        }


    }
}
