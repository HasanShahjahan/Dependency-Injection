using IdentityServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Services
{
    public class Manager : IManager
    {
        public readonly IType _type;
        public Manager (IType type)
        {
            _type = type;
        }
        public async Task ManageDevelopment()
        {
            await _type.Manage();
        }

        public async Task ManageManufacure()
        {
            await _type.Execute();
        }
    }
}
