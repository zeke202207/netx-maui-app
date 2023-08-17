using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetX.AppLauncher.Resources.Styles
{
    public partial class Styles : ResourceDictionary
    {
        public Styles()
        {
            this.MergedDictionaries.Add(new Colors());
            InitializeComponent();
        }
        
    }
}
