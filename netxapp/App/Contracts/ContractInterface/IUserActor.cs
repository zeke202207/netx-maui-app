using netxapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace netxapp.Contracts.ContractInterface
{
    public interface IUserActor
    {
        /// <summary>
        /// 会话连接入口
        /// 服务器级别保存用户会话信息等
        /// </summary>
        /// <param name="config">登录连接参数</param>
        /// <returns>连接是否成功，服务地址等信息</returns>
        Task<ConnectResult> Connnect(ConnectConfig config);

        Task<ResuleInfo> Identificate(LoginModel model);
    }
}
