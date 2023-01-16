using netxapp.Contracts.ContractInterface;
using netxapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Contracts.Net
{
    internal class NetxClusterFactory : IClusterFactory
    {
        private readonly ConnectResult FactoryInfo;

        private UserExecutor _userExecutor;

        public NetxClusterFactory(ConnectResult info)
        {
            FactoryInfo = info;
        }

        public IUserActor CreateUser()
        {
            _userExecutor = new UserExecutor();
            return _userExecutor;
        }
    }
}
