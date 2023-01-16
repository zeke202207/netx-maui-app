using Microsoft.Extensions.Configuration;
using Microsoft.Maui.Controls;
using netxapp.Contracts;
using netxapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.ViewModels
{
    internal sealed class Personal
    {
        private ISession _session = null;

        static Personal()
        {
            Instance = new Personal();
        }

        /// <summary>
        /// 用户个人信息
        /// </summary>
        public static Personal Instance { get; private set; }

        private Personal()
        {
            
        }

        private IApplication _application = null;
        private User _user = null;

        /// <summary>
        /// 获取当前用户所属部门
        /// </summary>
        public string CurrentUserDeptId
        {
            get
            {
                return _user.DeptId;
            }
        }

        /// <summary>
        /// 获取当前登录用户的唯一标识
        /// </summary>
        public string CurrentUserid { get { return _user.ID; } }

        /// <summary>
        /// 全局信息-来宾无会话操作处理
        /// </summary>
        public IApplication Applicate
        {
            get
            {
                return _application;
            }
        }

        /// <summary>
        /// 会话信息
        /// </summary>
        public ISession Session
        {
            get
            {
                return _session;
            }
        }

        /// <summary>
        /// 个人信息
        /// </summary>
        internal User User
        {
            get
            {
                return _user;
            }
        }

        /// <summary>
        /// 登录入口方法
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<bool> Login(string user, string password)
        {
            _session = await NSession.Connect(new Uri("http://127.0.0.1"), user, password);
            if (null == _session)
                return false;
            var info = await _session.UserActor.Identificate(new LoginModel() { UserName = user, Password = password });
            //用户信息注册
            if (info == null || info.ExitCode != 0)
                throw new Exception("login error");
            else
                _user = (User)info.StandardOut;            
            return true;
        }
    }
}
