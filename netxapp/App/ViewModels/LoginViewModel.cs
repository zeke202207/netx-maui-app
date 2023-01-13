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
            _router = router;
            ExecuteLogin = new Command(() => Login());
        }

        public string Username { get; set; } = "zeke";
        public string Password { get; set; } = "123456";

        public ICommand ExecuteLogin { get; set; }

        private void Login()
        {
            if (Username.ToLower().Equals("zeke") && Password.ToLower().Equals("123456"))
                _router.NavigateTo("//main/home");
            else
                LoginFailed?.Invoke("Invalid username or password");
        }
    }
}
