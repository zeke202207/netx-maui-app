using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Models
{
    public class ResuleInfo
    {
        private object _standardOut = null;
        private string _standardError = string.Empty;
        private ResultCode _exitCode;


        /// <summary>
        /// 构造函数
        /// </summary>
        public ResuleInfo()
        {
            _standardOut = null;
            _standardError = string.Empty;
            _exitCode = ResultCode.Success;
            ErrorCode = 0;
        }

        /// <summary>
        /// 返回成功结果
        /// </summary>
        /// <param name="outstandards">处理结果（可能承载实体）</param>
        /// <returns>结果实体</returns>
        public static ResuleInfo Success(object outstandards)
        {
            ResuleInfo info = new ResuleInfo();
            info.ExitCode = ResultCode.Success;
            info.StandardOut = outstandards;
            return info;
        }

        /// <summary>
        /// 返回错误结果
        /// </summary>
        /// <param name="errors">错误信息</param>
        /// <param name="outstandards">处理结果（可选）</param>
        /// <returns>结果实体</returns>
        public static ResuleInfo Error(string errors, int errorCode, object outstandards = null)
        {
            ResuleInfo info = new ResuleInfo();
            info.ExitCode = ResultCode.Failure;
            info.StandardOut = outstandards;
            info.StandardError = errors;
            info.ErrorCode = errorCode;
            return info;
        }

        /// <summary>
        /// 返回处理信息（可能过程有错误）
        /// </summary>
        /// <param name="outstandards">处理结果</param>
        /// <param name="errors">错误信息</param>
        /// <returns>结果实体</returns>
        public static ResuleInfo Complet(object outstandards, string errors, int errorCode)
        {
            ResuleInfo info = new ResuleInfo();
            info.ExitCode = ResultCode.CompleteWithError;
            info.StandardOut = outstandards;
            info.StandardError = errors;
            info.ErrorCode = errorCode;
            return info;
        }

        /// <summary>
        /// 退出标示，当为0时成功完成，其他状态参见常量类-->0:成功1：异常2：执行完成有错误
        /// </summary>
        [DataMember]
        public ResultCode ExitCode
        {
            get
            {
                return _exitCode;
            }
            set
            {
                _exitCode = value;
            }
        }

        /// <summary>
        /// 异常信息
        /// </summary>
        [DataMember]
        public string StandardError
        {
            get
            {
                return _standardError;
            }
            set
            {
                _standardError = value;
            }
        }

        /// <summary>
        /// 任务执行后，标准输出信息
        /// </summary>
        [DataMember]
        public object StandardOut
        {
            get
            {
                return _standardOut;
            }
            set
            {
                _standardOut = value;
            }
        }

        /// <summary>
        /// 错误码, 0: 无错误, -1: 未知错误, 其它: 每个错误码对应一条错误记录
        /// </summary>
        [DataMember]
        public int ErrorCode { get; set; }
    }

    public enum ResultCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success,
        /// <summary>
        /// 异常,失败
        /// </summary>
        Failure,
        /// <summary>
        /// 执行完成，结果又错误
        /// </summary>
        CompleteWithError
    }
}
