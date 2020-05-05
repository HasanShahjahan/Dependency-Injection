using IdentityServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Modules
{
    public class Module
    {
        private readonly IManager _manager;
        private readonly IType _type;
        public Module (IManager manager, IType type)
        {
            _type = type;
            _manager = manager;
        }
        public async Task PrepareManufacturerTaskAsync() 
        {
            await _manager.ManageManufacure();
            await _type.Execute();
        }

        public async Task PrepareDevelopmentTaskAsync()
        {
            await _manager.ManageDevelopment();
            await _type.Manage();
        }

    }
}
