using netxapp.Controls.BusyIndicator;
using netxapp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace netxapp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly IRoutingService _router;
        public Action<string> LoginFailed;

        public LoginViewModel(IRoutingService router)
        {
            base.Title = "Login";
            _router = router;
            ExecuteLogin = new Command(async () =>await Login());
        }

        public string Username { get; set; } = "zeke";
        public string Password { get; set; } = "123456";

        public ICommand ExecuteLogin { get; set; }

        private async Task Login()
        {
            base.IsBusy = true;
            //模拟请求登录
            await Personal.Instance.Login(Username, Password);
            base.IsBusy = false;
            //业务跳转
            if (Username.ToLower().Equals("zeke") && Password.ToLower().Equals("123456"))
               await _router.NavigateTo("//main/home");
            else
               LoginFailed?.Invoke("Invalid username or password");
        }
    }
}
