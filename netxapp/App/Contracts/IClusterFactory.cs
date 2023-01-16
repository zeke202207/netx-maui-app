using netxapp.Contracts.ContractInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Contracts
{
    internal interface IClusterFactory
    {
        IUserActor CreateUser();
    }
}
