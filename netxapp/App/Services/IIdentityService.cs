using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Services
{
    public interface IIdentityService
    {
        Task<bool> VerifyRegistration();
        Task Authenticate();
    }
}
