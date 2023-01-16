using netxapp.Contracts.ContractInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Contracts
{
    /// <summary>
    ///  统一入口，策略模式
    /// </summary>
    /// <example>
    /// [示例代码在这里写入]
    /// </example>
    public interface ISession
    {
        IUserActor UserActor { get; }
    }
}
