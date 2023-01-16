using netxapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Contracts
{
    internal static class NSession
    {
        public static async Task<ISession> Connect(Uri clusterName, string userName, string password)
        {
            NetxSession footFCloud = null;
            ConnectResult mConnectResult = null;
            UserExecutor user = new UserExecutor();
            if (string.IsNullOrEmpty(Convert.ToString(clusterName).TrimEnd()))
                throw new ArgumentNullException("Uri is NullOrEmpty");

            ConnectConfig config = new ConnectConfig();
            config.UserName = userName;
            config.Password = password;
            mConnectResult = await user.Connnect(config);
            if (null != mConnectResult &&
                !mConnectResult.Haserror &&
                string.IsNullOrEmpty(mConnectResult.ErrorMsg))
            {
                footFCloud = new NetxSession();
                //初始化环境
                footFCloud.InitEnviriment(mConnectResult);
            }
            return footFCloud;
        }
    }
}
