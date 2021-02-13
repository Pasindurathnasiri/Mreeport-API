using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MReportAPI.Data;
using MReportAPI.Models;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MReportAPI.Handler
{
    public class DoctorAuthhandle : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly MReportAPIContext Acontext;

        public DoctorAuthhandle(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock systemClock,
            MReportAPIContext context) :
                base(options, logger, encoder, systemClock)
        {
            Acontext = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {

            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Authorization header Not Found");

            try
            {
                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);
                var bytecredentials = Encoding.UTF8.GetString(bytes);
                string[] credentials = bytecredentials.Split(":");
                string id = credentials[0];
                string password = credentials[1];

                Doctor doctor = Acontext.Doctor.Where(doctor => doctor.NIC == id && doctor.Password == password)
                                               .FirstOrDefault();

                if (doctor == null)
                {
                    AuthenticateResult.Fail("invalid user");
                }

                else
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, doctor.NIC) };
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principle = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principle, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }
            }
            catch (Exception)
            {

                return AuthenticateResult.Fail("error occured");
            }

            return AuthenticateResult.Fail("need to implement");

        }
    }
}