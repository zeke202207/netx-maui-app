using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Models
{
    public class ConnectResult
    {
        /// <summary>
        /// 是否存在错误，为客户端连接判断的核心
        /// </summary>
        [DataMember]
        public bool Haserror { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [DataMember]
        public string ErrorMsg { get; set; }
    }
}
