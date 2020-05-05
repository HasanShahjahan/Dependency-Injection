using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Interfaces
{
    public interface IManager
    {
        Task ManageManufacure();
        Task ManageDevelopment();
    }
}
