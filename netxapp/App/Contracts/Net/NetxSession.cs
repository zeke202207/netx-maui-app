using netxapp.Contracts.ContractInterface;
using netxapp.Contracts.Net;
using netxapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Contracts;

internal class NetxSession : ISession
{
    private NetxClusterFactory _netxFactory;
    private IUserActor _userActor;

    /// <summary>
    /// 初始化云计算集群环境
    /// 创建工厂方法中的产品对象
    /// </summary>
    /// <param name="connectionInfo">连接后，返回的结果信息</param>
    internal void InitEnviriment(ConnectResult connectionInfo)
    {
        _netxFactory = new NetxClusterFactory(connectionInfo);
        _userActor = _netxFactory.CreateUser();
    }

    public IUserActor UserActor
    {
        get { return _userActor;}
    }
}

