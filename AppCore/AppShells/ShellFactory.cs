using NetX.AppCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore
{
    public static class ShellFactory
    {
        /// <summary>
        /// 创建内置shell
        /// </summary>
        /// <param name="shellType"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static Shell CreateDefaultShell(Func<ShellConfig> action)
        {
            var config = action?.Invoke();
            return CreateShell(ShellType.NetXShell, ()=> config, null);
        }

        /// <summary>
        /// 创建自定义shell
        /// </summary>
        /// <param name="customerShell"></param>
        /// <returns></returns>
        public static Shell CreateCustomShell(Func<Shell> customerShell)
        {
            return CreateShell(ShellType.CustomerShell, null, customerShell);
        }

        /// <summary>
        /// 创建shell
        /// </summary>
        /// <param name="shellType">创建shell类型</param>
        /// <param name="customerShell">自定义shell</param>
        /// <returns></returns>
        internal static Shell CreateShell(ShellType shellType, Func<ShellConfig> config, Func<Shell> customerShell)
        {
            var shell = shellType switch
            {
                ShellType.NetXShell => new NetXAppShell(config.Invoke()),
                ShellType.CustomerShell => null != customerShell ? customerShell?.Invoke() : throw new NotImplementedException("未实现自定义shell"),
                _ => throw new NotSupportedException("不支持的ShellType"),
            };
            NetXApp.Shell = shell;
            return shell;
        }
    }
}
