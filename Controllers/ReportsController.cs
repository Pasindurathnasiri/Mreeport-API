using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MReportAPI.Data;
using MReportAPI.Data.EFCore;
using MReportAPI.Models;

namespace MReportAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : MReportAPIController<Report, EFCoreReportRepository>
    {
        public ReportsController(EFCoreReportRepository repository) : base(repository)
        {

        }
    }
}
