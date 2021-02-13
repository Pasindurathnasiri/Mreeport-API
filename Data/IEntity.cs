using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MReportAPI.Data
{
    public interface IEntity
    {
        int Id { get; set; }

    }

    public interface IHAuthEntity
    {
        int Id { get; set; }
        string Password { get; set; }
        string OwnerNIC { get; set; }
    }

    public interface IAuthEntity
    {
        int Id { get; set; }
        string NIC { get; set; }
        string Password { get; set; }

    }
}
