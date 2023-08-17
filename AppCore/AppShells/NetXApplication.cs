using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppCore.AppShells
{
    public class NetXApplication : Application
    {
        private static Lazy<NetXApplication> instance = new Lazy<NetXApplication>(() => new NetXApplication());

        public static NetXApplication Instance { get { return instance.Value; } }

        private NetXApplication()
        {

        }

        public void AddResources(params ResourceDictionary[] sources)
        {
            foreach (var source in sources)
            {
                Instance.Resources.Add(source);
            }
        }

        public NetXApplication CreateShell(Func<Shell> funcShell)
        {
            MainPage = funcShell?.Invoke();
            return this;
        }
    }
}
