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
        public Action<bool, string> LoginResult;

        public LoginViewModel()
        {
            ExecuteLogin = new Command(() => Login());
        }

        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public ICommand ExecuteLogin { get; set; }

        private void Login()
        {
            if (Username.ToLower().Equals("zeke") && Password.ToLower().Equals("123456"))
                LoginResult?.Invoke(true, string.Empty);
            else
                LoginResult?.Invoke(false, "Invalid username or password");
        }
    }
}
