using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Services
{
    public class IdentityService :IIdentityService
    {
        public Task Authenticate()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> VerifyRegistration()
        {
            await Task.Delay(1 * 1000);
            return true;
        }
    }
}
