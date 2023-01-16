using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netxapp.Contracts;

internal class BaseExecutor
{
    protected readonly HttpClient _client;

    internal BaseExecutor(HttpClient client)
    {
        _client= client;
    }
}
