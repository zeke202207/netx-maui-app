using netxapp.Contracts.ContractInterface;
using netxapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Contracts
{
    internal class UserExecutor : BaseExecutor, IUserActor
    {
        internal UserExecutor()
            :base(new HttpClient())
        {
           
        }

        public async Task<ConnectResult> Connnect(ConnectConfig config)
        {
            //var result = await base._client.PostAsJsonAsync<ConnectConfig>("", config);
            return new ConnectResult();
        }

        public async Task<ResuleInfo> Identificate(LoginModel model)
        {
            //模拟网络通信
            await Task.Delay(2 * 1000);
            return await Task.FromResult<ResuleInfo>(ResuleInfo.Success(new User() { ID = "001", DeptId = "002" }));
        }
    }
}
