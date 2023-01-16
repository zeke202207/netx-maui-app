using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Models;

public sealed class ConnectConfig
{
    public ConnectConfig()
    {
    }

    public string UserName { get; set; }

    public string Password { get; set; }
}
